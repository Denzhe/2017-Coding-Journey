//  All code copyright (c) 2003 Barry Lapthorn
//  Website:  http://www.lapthorn.net
// https://www.codeproject.com/Articles/3172/A-Simple-C-Genetic-Algorithm

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithm
{

    public delegate double GAFunction(double[] values);

    public class GA
    {

        private double g_mutationRate;
        private double g_crossoverRate;
        private int g_populationSize;
        private int g_generationSize;
        private int g_genomeSize;
        private double g_totalFitness;
        private string g_strFitness;
        private bool g_elitism;

        private ArrayList g_thisGeneration;
        private ArrayList g_nextGeneration;
        private ArrayList g_fitnessTable;

        static readonly Random g_Random = new Random();

        static private GAFunction getFitness;

        public GAFunction FitnessFunction
        {
            get => getFitness;
            set => getFitness = value;
        }

        public double G_MutationRate
        {
            get => g_mutationRate;
            set => g_mutationRate = value;
        }

        public double G_CrossoverRate
        {
            get => g_crossoverRate;
            set => g_crossoverRate = value;

        }
        public int G_populationSize
        {
            get => g_populationSize;
            set => g_populationSize = value;
        }


        public int G_GenerationSize
        {
            get => g_generationSize;
            set => g_generationSize = value;
        }

        public int G_GenomeSize
        {
            get => g_genomeSize;
            set => g_genomeSize = value;
        }

        public double G_totalFitness
        {
            get => g_totalFitness;
            set => g_totalFitness = value;
        }

        public string FitnessFile
        {
            get => g_strFitness;
            set => g_strFitness = value;
        }

        public bool G_Elitism
        {
            //Keeps the fittest from the weakest
            get => g_elitism;
            set => g_elitism = value;
        }

        public GA()
        {
            InitialValues();
            g_mutationRate = 0.05;
            g_crossoverRate = 0.80;
            g_populationSize = 100;
            g_generationSize = 2000;
            g_strFitness = "";

        }


        public GA(double crossoverRate, double mutationRate, int populationSize, int generationSize, int genomeSize)
        {
            g_mutationRate = mutationRate;
            g_crossoverRate = crossoverRate;
            g_populationSize = populationSize;
            g_generationSize = generationSize;
            g_genomeSize = genomeSize;
            g_strFitness = "";

        }


        public GA(int genomeSize)
        {
            InitialValues();
            g_genomeSize = genomeSize;
        }


        public void InitialValues()
        {
            g_elitism = false;
        }

        /// <summary>
        /// Method that starts the GA execution
        /// </summary>
        public void Go()
        {
            if (getFitness == null)
            {
                throw new ArgumentNullException("Need to supply fitness function");
            }

            if (g_genomeSize == 0)
            {
                throw new IndexOutOfRangeException("Genome size not set");
            }

            // Create the fitness table
            g_fitnessTable = new ArrayList();
            g_thisGeneration = new ArrayList();
            g_nextGeneration = new ArrayList();

            Genome.MutationRate = g_mutationRate;

            CreateGenomes();
            RankPopulation();

            StreamWriter outputFitness = null;
            bool write = false;

            if (g_strFitness != "")
            {
                write = true;
                outputFitness = new StreamWriter(g_strFitness);
            }

            for (int i = 0; i < g_generationSize; i++)
            {
                CreateNextGeneration();
                RankPopulation();

                if (write)
                {
                    if (outputFitness != null)
                    {
                        double d = (double)((Genome)g_thisGeneration[g_populationSize - 1]).Fitness;
                        outputFitness.WriteLine($"{i},{d}");
                    }
                }

            }

            if (outputFitness != null)
            {
                outputFitness.Close();
            }
        }

        /// <summary>
        /// After ranking all the genomes by fitness.This method allocates a high probability
        /// of selection to those highest fitness
        /// </summary>
        /// <returns>Random individual biased to highest fitness </returns>
        private int RouletteSelection()
        {
            double randomFitness = g_Random.NextDouble() * g_totalFitness;

            int index = -1;
            int mid;
            int first = 0;
            int last = g_populationSize - 1;
            mid = (last - first) / 2;


            //Array list Binary search is for exact values only;


            while (index == -1 && first <= last)
            {
                if (randomFitness < (double)g_fitnessTable[mid])
                {
                    last = mid;
                }

                else if (randomFitness > (double)g_fitnessTable[mid])
                {
                    first = mid;
                }

                mid = (first + last) / 2;
                if ((last - first) == 1)
                {
                    index = last;
                }
            }

            return index;
        }

        /// <summary>
        /// Rank population and sort in order of fitness
        /// </summary>
        private void RankPopulation()
        {
            g_totalFitness = 0;
            for (int i = 0; i < g_populationSize; i++)
            {
                Genome g = ((Genome)g_thisGeneration[i]);
                g.Fitness = FitnessFunction(g.Genes());
                g_totalFitness += g.Fitness;
            }

            g_thisGeneration.Sort(new GenomeComparer());

            //  now sorted in order of fitness.

            double fitness = 0.0;
            g_fitnessTable.Clear();


            for (int i = 0; i < g_populationSize; i++)
            {
                fitness += ((Genome)g_thisGeneration[i]).Fitness;
                g_fitnessTable.Add((double)fitness);

            }


        }

        private void CreateGenomes()
        {
            for (int i = 0; i < g_populationSize; i++)
            {
                Genome g = new Genome(g_genomeSize);
                g_thisGeneration.Add(g);
            }
        }

        private void CreateNextGeneration()
        {
            g_nextGeneration.Clear();
            Genome g = null;
            if (g_elitism)
                g = (Genome)g_thisGeneration[g_populationSize - 1];

            for (int i = 0; i < g_populationSize; i += 2)
            {
                int pidx1 = RouletteSelection();
                int pidx2 = RouletteSelection();

                Genome parent1, parent2, child1, child2;
                parent1 = ((Genome)g_thisGeneration[pidx1]);
                parent2 = ((Genome)g_thisGeneration[pidx2]);

                if (g_Random.NextDouble() < g_mutationRate)
                {
                    parent1.Crossover(ref parent2, out child1, out child2);
                }
                else
                {
                    child1 = parent1;
                    child2 = parent2;

                }


                child1.Mutate();
                child2.Mutate();

                g_nextGeneration.Add(child1);
                g_nextGeneration.Add(child2);


            }
            if (g_elitism && g != null)
                g_nextGeneration[0] = g;

            g_thisGeneration.Clear();

            for (int i = 0; i < g_populationSize; i++)
            {
                g_thisGeneration.Add(g_nextGeneration[i]);
            }

        }


        public void GetBest(out double[] values, out double fitness)
        {
            Genome g = ((Genome)g_thisGeneration[g_populationSize - 1]);
            values = new double[g.Length];
            g.GetValues(ref values);
            fitness = (double)g.Fitness;
        }

        public void GetWorst(out double[] values, out double fitness)

        {
            GetNthGenome(0, out values, out fitness);
        }

        public void GetNthGenome(int n, out double[] values, out double fitness)
        {
            if (n < 0 || n > g_populationSize - 1)
                throw new ArgumentOutOfRangeException("n too large,or too small");
            Genome g = ((Genome)g_thisGeneration[n]);
            values = new double[g.Length];
            g.GetValues(ref values);
            fitness = (double)g.Fitness;
            
        }
    }
}

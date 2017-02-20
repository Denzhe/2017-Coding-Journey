//  All code copyright (c) 2003 Barry Lapthorn
//  Website:  http://www.lapthorn.net
//

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

        static Random g_Random = new Random();
        static private GAFunction getFitness;

        public GAFunction GetFitness
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

        public bool G_elitism
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


        public GA(double crossoverRate,double mutationRate,int populationSize,int generationSize,int genomeSize)
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
        }
    }
}

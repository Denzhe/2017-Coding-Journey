using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithm
{
  public  class Genome
    {
        public double[] g_genes;
        private int g_length;
        private double g_fitness;
        static readonly Random g_random = new Random();
        private static double g_mutationRate;


        /// <summary>
        /// 
        /// </summary>
        public double Fitness
        {
            get { return g_fitness; }
            set { g_fitness = value; }
        }


        public int Length
        {
            get { return g_length; }
          
        }

        public static double MutationRate
        {
            get { return g_mutationRate; }
            set { g_mutationRate = value; }
        }

    


        public Genome()
        {
            ///Default constructor 
        }

        public Genome(int length)
        {

            g_length = length;
            g_genes = new double[g_length];
            CreateGenes();
        }

      

        public Genome(int length,bool createGenes)
        {
            g_length = length;
            g_genes = new double[g_length];
            if (createGenes)
            {
                CreateGenes();
            }
        }




        private void CreateGenes()
        {
            for (int i = 0; i < g_length; i++)
            {
                g_genes[i] = g_random.NextDouble();
            }
        }


        public void Crossover(ref Genome genome2,out Genome child1,out Genome child2)
        {
            int pos = (int)(g_random.NextDouble() * (double)g_length);
            child1 = new Genome(g_length, false);
            child2 = new Genome(g_length, false);
            for (int i = 0; i < g_length; i++)
            {
                if (i < pos)
                {
                    child1.g_genes[i] = g_genes[i];
                    child2.g_genes[i] = genome2.g_genes[i];

                }
                else
                {
                    child1.g_genes[i] = genome2.g_genes[i];
                    child2.g_genes[i] = g_genes[i];
                }
            }
        }

        public void Mutate()
        {
            for (int pos = 0; pos < g_length; pos++)
            {
                if (g_random.NextDouble() < g_mutationRate)
                {
                    g_genes[pos] = (g_genes[pos] + g_random.NextDouble()) / 2.0;
                }
            }
        }


        public double [] Genes()
        {
            return g_genes;
        }

        public void Output()
        {
            for (int i = 0; i < g_length; i++)
            {
                Console.WriteLine($"{g_genes[i]:f4}");
            }
        }


        public void GetValues(ref double[] values)
        {
            for (int i = 0; i < g_length; i++)
            {
                values[i] = g_genes[i];
            }
        }
    }
}

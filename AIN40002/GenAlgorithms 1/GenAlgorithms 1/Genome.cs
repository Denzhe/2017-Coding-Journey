using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithms_1
{
    class Genome
    {
        private int[] dna;
        private int DNAlength = 20;
        private double fitness;
        public static readonly Random g_random = new Random();
        private int v;

        protected int[] DNA { get => dna; set => dna = value; }

        public double Fitness
        {
            get { return fitness; }
            set { fitness = 0; }
        }

        public int Length
        {
            get { return DNAlength; }

            set { DNAlength = 20; }

        }

        public Genome(int length, bool generateDNA)
        {
            DNAlength = length;
            dna = new int[DNAlength];
            if (generateDNA)
            {
                CreateGenes();
            }

        }

        public Genome(int length)
        {

             DNAlength = length;
            dna = new int[DNAlength];
            CreateGenes();
        }

        private void CreateGenes()
        {
            for (int i = 0; i < DNAlength; i++)
            {
                dna[i] = g_random.Next();
            }
        }

        public void SinglePointCrossOver( ref Genome genome2, out Genome child1, out Genome child2)
        {
            int crossValue = (int)(g_random.NextDouble() * (double)DNAlength);
            child1 = new Genome(DNAlength, false);
            child2 = new Genome(DNAlength, false);
            for (int i = 0; i < DNAlength; i++)
            {
                if (i < crossValue)
                {
                    child1.dna[i] = dna[i];
                    child2.dna[i] = genome2.dna[i];

                }
                else
                {
                    child1.dna[i] = genome2.dna[i];
                    child2.dna[i] = dna[i];
                }
            }
        }
    }
}

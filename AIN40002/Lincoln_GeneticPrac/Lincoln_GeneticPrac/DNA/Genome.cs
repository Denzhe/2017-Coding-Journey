using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lincoln_GeneticPrac
{
  public class Genome
    {
        public int [] DNA { get; set; }

        public double Fit = 0;

        public Genome(bool generate)
        {
            DNA = new int[DNAattributes.DNA_Length];
            if (generate)
            {
                for (int i = 0; i < DNAattributes.DNA_Length; i++)
                {
                    DNA[i] = DNAattributes.rnd.Next(0, 27);
                }
            }

            else
            {
                for (int i = 0; i < DNAattributes.DNA_Length; i++)
                {
                    DNA[i] = 0;
                }
            }
        }

        public void Fitness(int i)
        {

            double sum = 0;
            for (int j = 0; j < DNAattributes.DNA_Length; j++)
            {
                sum += Math.Abs(DNAattributes.target[j] - DNAattributes.pop[i].DNA[j]);
            }

            DNAattributes.pop[i].Fit = 1/ (1 + sum) + 0.01;
            if (DNAattributes.pop[i].Fit < DNAattributes.bestGenome)
            {
                DNAattributes.bestGenome = DNAattributes.pop[i].Fit;
                DNAattributes.bestGenomeIndex = 1;

            }

        }


        public void PrintFun(int [] dna,string text)
        {
            Log.Write(text.PadRight(20));
            for (int i = 0; i < DNAattributes.DNA_Length; i++)
            {
                Write(dna[i]);
            }
            Log.WriteLine();
            Console.WriteLine();
        }

        private void Write(int v)
        {
            Console.Write(DNA[v].ToString() + ".");
            Log.Write(DNA[v].ToString() + ".");

        }

        public void CalculateFitness()
        {
            DNAattributes.popTotalFitness = 0;
            for (int i = 0; i < DNAattributes.PopulationSize; i++)
            {
                Fitness(i);
            }
        }

        public Genome(int [] _DNA)
        {
            DNA = new int[DNAattributes.DNA_Length];
            DNA = _DNA;
        }
    }
}

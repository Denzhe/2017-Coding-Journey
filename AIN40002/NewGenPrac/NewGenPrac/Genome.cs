using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGenPrac
{
    class Genome
    {
        int [] DNA {get;set;}
        int DNA_Length = 20;
        double CrossOverRate = 0.7;
        public double Fitness = 0;
        static readonly  Random seed = new Random();


        public Genome(bool  generate)
        {
            DNA = new int[DNA_Length];
            if (generate)
            {
                for (int i = 0; i <= DNA_Length - 1; i++)
                {
                    DNA[i] = seed.Next(0,2);
                }
            }

           
        }

        public Genome(int [] myDNA)
        {
            DNA = new int[DNA_Length];
            DNA = myDNA;
        }



        public void SinglePointCrossOver(Genome parent1,Genome parent2,Genome child1,Genome child2)
        {
           
            int crossOVerPoint = 0;

            if (seed.Next(0,2) < CrossOverRate)
            {
                child1 = parent1;
                child2 = parent2;
            }
            else
            {
                crossOVerPoint = seed.Next(0, DNA_Length);
                Logger.Writeline("CrossOverValue: " + crossOVerPoint);
                Logger.Writeline("--------------------------------------------------");
                Console.WriteLine("CrossOverValue: " + crossOVerPoint);
                Console.WriteLine("--------------------------------------------------");

                for (int i = 0; i <= crossOVerPoint; i++)
                {
                    child1.DNA[i] = parent1.DNA[i];
                    child2.DNA[i] = parent2.DNA[i];
                }

                for (int i = crossOVerPoint + 1; i <= DNA_Length - 1; i++)
                {
                    child1.DNA[i] = parent2.DNA[i];
                    child2.DNA[i] = parent1.DNA[i];
                }


            }

            PrintF(parent1.DNA, "Parent one: ");
            PrintF(parent2.DNA, "Parent two: ");
            PrintF(child1.DNA, "Child one: ");
            PrintF(child2.DNA, "Child two: ");
            Console.WriteLine("");
            Logger.Writeline();

        }

        public void TwoPointCrossOver(Genome parent1,Genome parent2,Genome child1,Genome child2)
        {
            int temp = seed.Next(0, DNA_Length);
            int temp1 = seed.Next(0, DNA_Length);

            if (temp > temp1)
            {
                int hold = temp1;
                temp1 = temp;
                temp = hold;
            }

            for (int i = 0; i <= temp; i++)
            {
                child1.DNA[i] = parent1.DNA[i];
                child2.DNA[i] = parent2.DNA[i];
            }

            for (int i= temp; i <= temp1 - 1 ; i++)
            {
                child1.DNA[i] = parent2.DNA[i];
                child2.DNA[i] = parent1.DNA[i];
            }

            for (int i = temp1; i <= DNA_Length - 1; i++)
            {
                child1.DNA[i] = parent1.DNA[i];
                child2.DNA[i] = parent2.DNA[i];
            }

            Logger.Writeline("CrossOverValue 1: " + temp + "  CrossOverValue 2: " + temp1);
            Logger.Writeline("--------------------------------------------------");
            Console.WriteLine("CrossOverValue 1: " + temp + "  CrossOverValue 2: " + temp1);
            Console.WriteLine("--------------------------------------------------");
            PrintF(parent1.DNA, "Parent one: ");
            PrintF(parent2.DNA, "Parent two: ");
            PrintF(child1.DNA, "Child one: ");
            PrintF(child2.DNA, "Child two: ");
        }

        public void PrintF(int [] dna,string text)
        {
            Console.Write(text.PadRight(DNA_Length));
            Logger.Write(text.PadRight(DNA_Length));

            for (int i = 0; i < DNA_Length; i++)
            {
                Console.Write(dna[i].ToString());
                Logger.Write(dna[i].ToString());
            }

            Logger.Writeline();
            Console.WriteLine();

        }

    }

   
}

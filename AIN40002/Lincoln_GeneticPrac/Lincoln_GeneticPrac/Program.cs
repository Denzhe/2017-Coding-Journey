using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lincoln_GeneticPrac.DNA;
namespace Lincoln_GeneticPrac
{
    class Program
    {

        static double convergence = 0.0;
        static List<Genome> genome = new List<Genome>();

        static void Main(string[] args)
        {
            DNAattributes.rnd = new Random();
            DNAattributes.TargetSentence = new string[] { "t", "h", "i", "s", " ", "i", "s", " ", "a", " ", "t", "e", "s", "t", " ", "s", "e", "n", "t", "e", "n", "c", "e" };
            DNAattributes.target = DNA.Encoding.Encoded();
            Epoc();
            Console.ReadLine();
        }

        public static void NextGen()
        {
            Genome c1 = new Genome(false);
            Genome c2 = new Genome(false);
            RouletteWheelSelection select = new RouletteWheelSelection();
            CrossOver cross = new CrossOver();

            cross.SinglePointCrossOver(select.RouletteWheelSelect(), select.RouletteWheelSelect(), ref c1, ref c2);
            Mutate(ref c1);
            Mutate(ref c2);
            genome.Add(c1);
            genome.Add(c2);
            if (genome.Count == DNAattributes.PopulationSize)
            {
                DNAattributes.pop = genome;
            }
        }

        private static void Mutate(ref Genome gene)
        {
            if (DNAattributes.rnd.Next(0,2) > DNAattributes.MutationRate)
            {
                int dexChange = DNAattributes.rnd.Next(0, DNAattributes.DNA_Length);
                int value = DNAattributes.rnd.Next(0, 27);
                gene.DNA[dexChange] = value;
            }
        }


        public static double Convergene()
        {
            return convergence += 0.01;
        }
        private static void Epoc()
        {

            DNAattributes.pop = new List<Genome>();
            for (int i = 0; i < DNAattributes.PopulationSize; i++)
            {
                DNAattributes.pop.Add(new Genome(true));
            }

            Genome g = new Genome(false);

            while (convergence <= 0.95)
            {
                g.CalculateFitness();

                NextGen();

                Console.WriteLine("Population Fitness: " + DNAattributes.popTotalFitness);
                Console.WriteLine("Best Fitness: " + DNAattributes.bestGenome);
                Console.WriteLine("Best Fitness index: " + DNAattributes.bestGenomeIndex);
                Console.WriteLine("Decoded Value: ");
                Console.ForegroundColor = ConsoleColor.Red;
                DNA.Encoding.Decode(DNAattributes.pop[DNAattributes.bestGenomeIndex]);
                Console.ForegroundColor = ConsoleColor.White;
            } 
        }
    }
}

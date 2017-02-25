//  All code copyright (c) 2003 Barry Lapthorn
//  Website:  http://www.lapthorn.net
// https://www.codeproject.com/Articles/3172/A-Simple-C-Genetic-Algorithm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenAlgorithm;
namespace GATest
{
    class Program
    {

        public static double theActualFunction(double[] values)
        {
            if (values.GetLength(0) != 2)
                throw new ArgumentOutOfRangeException("Should only have 2 args");

            double x = values[0];
            double y = values[1];
            double n = 9;

            double f1 = Math.Pow(15 * x * y * (1 - x) * (1 - y) * Math.Sin(n * Math.PI * x) * Math.Sin(n * Math.PI * y), 2);
            return f1;

        }


        static void Main(string[] args)
        {
            //  Crossover		= 80%
            //  Mutation		=  5%
            //  Population size = 100
            //  Generations		= 2000
            //  Genome size		= 2

            GA ga = new GA(0.8,0.05,10,10,2);


            ga.FitnessFunction = new GAFunction(theActualFunction);

            ga.FitnessFile = @"F:\fitness.txt";
            ga.G_Elitism = true;
            ga.Go();

            double[] values;
            double fitness;

            ga.GetBest(out values, out fitness);
            Console.WriteLine("Best ({0}):", fitness);
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine("{0} ", values[i]);


            ga.GetWorst(out values, out fitness);
            Console.WriteLine("\nWorst ({0}):", fitness);
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine("{0} ", values[i]);


            Console.ReadLine();
        }
    }
}

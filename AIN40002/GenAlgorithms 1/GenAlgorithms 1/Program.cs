using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithms_1
{
    class Program
    {
        public static double calcFit(double values)
        {
            double f1;

            return f1 = values;
            
        }

        static void Main(string[] args)
        {

            GA ga = new GA();
            ga.FitnessFunction = new GAFunction(calcFit);
            ga.FitFile = @"F:\fitness.csv"; ;
            ga.writeLog();

            Console.WriteLine("It worked");
        }

     
    }
}

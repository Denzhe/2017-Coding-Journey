using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGenPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of iterations: ");
            int numIterations = int.Parse(Console.ReadLine());
            Genome g = new Genome(false);
            string[] letter = new string[23];

            letter[0] = "THIS IS A TEST SENTENCE";

            Logger.Write("Execute time: " + DateTime.Now.ToShortDateString());

            for (int i = 0; i <= numIterations ; i++)
            {
                Write("SinglePointCrossover");
                g.SinglePointCrossOver(new Genome(true),new Genome(true),new Genome(false),new Genome(false));
                Write(" ");
              //  g.Decode(new Genome(true));
               // g.Decode(new Genome(new [] { 84, 72, 73, 83, 32, 73, 83, 32, 65, 32, 84, 69, 83, 84, 32, 83, 69, 78, 84, 69, 78, 67, 69, }));
              //  g.FitnessFun("THIS IS A TEST SENTENCE");

               g.CalculateFitness();
                Console.ForegroundColor = ConsoleColor.Red;
                Write("TwoPointCrossover");
                Console.ResetColor();
                g.TwoPointCrossOver(new Genome(true), new Genome(true), new Genome(false), new Genome(false));
                Write("__________________________________________________");

               
            }
           
            Console.ReadLine();
        }

        private static void Write(string s)
        {
            Logger.Writeline(s.PadLeft(35));
            Console.WriteLine(s.PadLeft(35));
        }
    }
}

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
            Logger.Write("Execute time: " + DateTime.Now.ToShortDateString());

            for (int i = 0; i <= numIterations ; i++)
            {
                Write("SinglePointCrossover");
                g.SinglePointCrossOver(new Genome(true),new Genome(true),new Genome(false),new Genome(false));
                Write(" ");
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

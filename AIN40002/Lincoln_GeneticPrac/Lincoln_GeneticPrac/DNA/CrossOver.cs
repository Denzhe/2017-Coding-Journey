using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lincoln_GeneticPrac.DNA
{
   internal class CrossOver
    {
        public void SinglePointCrossOver(Genome p1,Genome p2,ref Genome c1,ref Genome c2)
        {
            double crossOverRate = 0.7;
            int crossOverPoint = 0;

            if (DNAattributes.rnd.Next(0, DNAattributes.DNA_Length) < crossOverRate)
            {
                c1 = p1;
                c2 = p2;
            }
            else
            {
                crossOverPoint = DNAattributes.rnd.Next(0, DNAattributes.DNA_Length);
                LogMethod("CrossOverValue: ", crossOverPoint);
                Log.Write("------------------------------------");
                for (int i = 0; i < crossOverPoint; i++)
                {
                    c1.DNA[i] = p1.DNA[i];
                    c2.DNA[i] = p2.DNA[i];
                }

                for (int i = crossOverPoint + 1; i < DNAattributes.DNA_Length - 1; i++)
                {
                    c1.DNA[i] = p2.DNA[i];
                    c2.DNA[i] = p1.DNA[i];
                }
            }

            LogMethod();
        }

        public void TwoPointCrossOver(Genome p1,Genome p2,Genome c1,Genome c2)
        {
            int temp = DNAattributes.rnd.Next(0, DNAattributes.DNA_Length);
            int temp1 = DNAattributes.rnd.Next(0, DNAattributes.DNA_Length);

            if (temp > temp1)
            {
                int hold = temp1;
                temp1 = temp;
                temp = hold;
            }

            for (int i = 0; i <= temp ; i++)
            {
                c1.DNA[i] = p1.DNA[i];
                c2.DNA[i] = c2.DNA[i];
            }

            for (int i = temp + 1; i <= temp1 - 1; i++)
            {
                c1.DNA[i] = p2.DNA[i];
                c2.DNA[i] = p1.DNA[i];
            }

            for (int i = temp1 + 1; i <= DNAattributes.DNA_Length - 1; i++)
            {
                c1.DNA[i] = p1.DNA[i];
                c2.DNA[i] = c2.DNA[i];
            }

            LogMethod("Parent One", p1.DNA);
            LogMethod("Parent Two", p2.DNA);
            LogMethod("Child One", c1.DNA);
            LogMethod("Child Two", c2.DNA);
        }

        private void LogMethod(string v, int[] dNA)
        {
            Console.WriteLine();
            Console.Write(v.PadRight(30));
            Log.Write(v.PadRight(30));

            for (int i = 0; i <= DNAattributes.DNA_Length - 1; i++)
            {
                Console.Write(dNA[i].ToString() +".");
                Log.Write(dNA[i].ToString() +".");
            }

            Console.WriteLine();
            Log.WriteLine();

        }

        private void LogMethod()
        {
            Log.WriteLine();
            Console.WriteLine();
        }

        private void LogMethod(string v, int crossOverPoint)
        {
            Log.WriteLine(v + crossOverPoint.ToString());
            Console.WriteLine(v + crossOverPoint.ToString());
            Log.Write("------------------------------------");
            Console.Write("------------------------------------");
        }

      
    }
}

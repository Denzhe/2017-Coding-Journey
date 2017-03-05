using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategySorter.Client;
using System.Diagnostics;

namespace StrategySorter
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch watch = new Stopwatch() ;

        ///Used Lecturer Haskins stringArray
        string[] myStringArray = File.ReadAllLines(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Animal.txt");


            //You simply have to extend the client whatever sorting algorithm you want
            List<Sorter> Sorts = new List<Sorter>
            {
                //new MyUltimateSorter(new BSort(),new DisplayVerticle()),
                //new MyUltimateSorter(new InsertSort(),new DisplayHorizontal()),

                new BubbleSorterDisplayHorizontal(),
                new InsertionSorterDisplayVertical(),
                new  MergeSorterDisplayHorizontal()
            };

            foreach (Sorter s in Sorts)
            {
                watch.Start();
                s.CallBehaviours(myStringArray);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(s.GetType().Name +" "+ watch.ElapsedMilliseconds.ToString() + "ms");

                Console.ResetColor();
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}

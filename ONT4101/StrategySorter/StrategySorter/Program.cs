using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "A", "B", "C", "D" };

            List<Sorter> sorts = new List<Sorter>();
            sorts.Add(new Sorter(MyArray, new Bubble_Sort(), new BubbleOut()));

            foreach (Sorter item in sorts)
            {
                item.CallAlgorithm();
            }

            Console.ReadLine();
        }
    }
}

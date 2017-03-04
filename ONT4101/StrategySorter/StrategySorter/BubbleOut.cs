using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class BubbleOut : IOutput
    {

        public string[] Output(string[] MyArray)
        {
            Console.WriteLine("Test");
            string[] newarray = new string[MyArray.Length];

            for (int i = 0; i < MyArray.Length; i++)
            {
                newarray[i] = MyArray[i];
            }

            return newarray;
        }
    }
}

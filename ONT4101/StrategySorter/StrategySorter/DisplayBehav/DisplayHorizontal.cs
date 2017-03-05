using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class DisplayHorizontal : IDisplay
    {
        public void Display(string[] myString)
        {
            foreach (string i in myString)
            {
                Console.WriteLine(i.ToString());
            }
           
        }
    }
}

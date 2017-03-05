using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class BSort : ISort
    {
        public void Sort(string[] myString)
        {
            bool swapped = true;
            string temp = " ";

            do
            {
                swapped = false;

                for (var i = 0; i < myString.Length - 1; i++)
                {
                    if (string.Compare(myString[i], myString[i + 1]) >= 0)
                    {
                        temp = myString[i];
                        myString[i] = myString[i + 1];
                        myString[i + 1] = temp;
                        swapped = true;
                    }

                }
            } while (swapped == true);
        }
    }
}

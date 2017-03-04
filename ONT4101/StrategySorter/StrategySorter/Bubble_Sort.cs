using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class Bubble_Sort : ISort
    {
        
   
        public void Sort(string[] MyArray)
        {
            //this.watch.Start();
            bool swapped = true;
            string temp = " ";

            do
            {
                swapped = false;

                for (var i = 0; i < MyArray.Length - 1; i++)
                {
                    if (string.Compare(MyArray[i], MyArray[i + 1]) >= 0)
                    {
                        temp = MyArray[i];
                        MyArray[i] = MyArray[i + 1];
                        MyArray[i + 1] = temp;
                        swapped = true;
                    }

                }
            } while (swapped == true);

            //this.watch.Stop();
        }
    }
}

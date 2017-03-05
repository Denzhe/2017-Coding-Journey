using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class InsertSort : ISort
    {
        public void Sort(string[] MyArray)
        {

            for (int i = 0; i < MyArray.Length - 1; i++)
            {

                int j = i + 1;
                string temp = MyArray[j];

                while (j > 0 && string.Compare(temp, MyArray[j - 1], true) < 0)
                {
                    MyArray[j] = MyArray[j - 1];
                    j--;
                }

                MyArray[j] = temp;

            }
        }
    }
}

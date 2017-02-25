using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class SelectionSort : Sorter
    {

        public SelectionSort(string[] MyArray) : base(MyArray)
        {


        }

        public override string[] Output()
        {
            string[] newArray = new string[MyArray.Length];

            for (int i = 0; i < MyArray.Length; i++)
            {
                newArray[i] = MyArray[i];
            }

            return newArray;
        }


        public override void Sort()
        {
            this.watch.Start();


            for (int i = 0; i < MyArray.Length -1; i++)
            {
                int maxIndex = i;
                for (int j = 0; j < MyArray.Length; j++)
                {
                    if (string.Compare(MyArray[j], MyArray[maxIndex]) >= 0)
                    {
                        maxIndex = j;
                    }
                        
                }

                Swap(i, maxIndex);
            }
        }

    }
}

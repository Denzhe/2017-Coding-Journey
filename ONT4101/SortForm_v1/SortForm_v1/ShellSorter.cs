using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class ShellSorter : Sorter
    {
        public ShellSorter(string[] MyArray) : base(MyArray)
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
            int gap = MyArray.Length / 2;
            while (gap > 0)
            {
                for (int i = 0; i < MyArray.Length - gap; i++)
                {
                    int j = i + gap;
                    string temp = MyArray[j];

                    while (j >= gap && string.Compare(temp,MyArray[j - gap])> 0)
                    {

                        MyArray[j] = MyArray[j - gap];
                        j -= gap;
                    }
                    MyArray[j] = temp;
                }
                gap = (int)(gap / 2);
            }
            this.watch.Stop();


        }


    }
}

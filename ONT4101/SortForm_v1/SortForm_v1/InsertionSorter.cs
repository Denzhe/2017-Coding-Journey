using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class InsertionSorter : Sorter
    {
        public InsertionSorter(string[] MyArray) : base(MyArray)
        {

        }



        public override string[] Output()
        {
            string[] newarray = new string[MyArray.Length];

            for (int i = 0; i < MyArray.Length; i++)
            {
                newarray[i] = MyArray[i];
            }

            return newarray;
        }

        public override void Sort()
        {

            this.watch.Start();

            for (int i = 0; i < MyArray.Length - 1; i++)
            {

                int j = i + 1;
                string temp = MyArray[j];

                while (j > 0 && string.Compare( temp,MyArray[j - 1],true) < 0)
                {
                    MyArray[j] = MyArray[j - 1];
                    j--;
                }

                MyArray[j] = temp;

            }
            this.watch.Stop();

        }
    }
}

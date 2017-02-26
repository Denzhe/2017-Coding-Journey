using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class BuiltInSorter : Sorter
    {
        public BuiltInSorter(string[] MyArray) : base(MyArray)
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

            Array.Sort(MyArray);

            this.watch.Stop();
        }
    }
}

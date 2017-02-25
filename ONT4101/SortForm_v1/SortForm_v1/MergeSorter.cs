using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class MergeSorter : Sorter
    {
        int[] Aux;
        public MergeSorter(string[] MyArray) : base(MyArray)
        {
        }

        public override string[] Output()
        {

            string[] mynewArray = new string[MyArray.Length];

            for (int i = 0; i < MyArray.Length; i++)
            {
                mynewArray[i] = MyArray[i];
            }

            return mynewArray;
        }


        public override void Sort()
        {
            this.watch.Start();

            Aux = new int[MyArray.Length];


        }
    }
}

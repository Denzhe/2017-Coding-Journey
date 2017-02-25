using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class MergeSorter : Sorter
    {
        string[] Aux;
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

            Aux = new string[MyArray.Length];
            MergeSort(0, MyArray.Length - 1);

        }

        public void MergeSort(int left, int right)
        {
            if (left == right) return;
            int middleIndex = (left + right) / 2;
            MergeSort(left, middleIndex);
            MergeSort(middleIndex + 1, right);
            Merge(left, right);

            for (int i = left; i <= right; i++)
            {
                MyArray[i] = Aux[i];
            }
            
        }

        private void Merge(int left,int right)
        {
            int middleIndex = (left + right) / 2;
            int leftIndex = left;
            int rightIndex = middleIndex + 1;


        }
    }
}

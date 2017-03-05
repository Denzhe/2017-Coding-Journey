using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter.Sort_Algo
{
    class MergeSort : ISort
    {
        string[] Aux;
        string[] MyArray;
        public void Sort(string[] MyArray)
        {
            Aux = new string[MyArray.Length];
            this.MyArray = new string[MyArray.Length];
            MergeS(0, MyArray.Length - 1);
        }



        public void MergeS(int left, int right)
        {
            if (left == right) return;
            int middleIndex = (left + right) / 2;
            MergeS(left, middleIndex);
            MergeS(middleIndex + 1, right);
            Merge(left, right);

            for (int i = left; i <= right; i++)
            {
                MyArray[i] = Aux[i];
            }

        }

        private void Merge(int left, int right)
        {
            int middleIndex = (left + right) / 2;
            int leftIndex = left;
            int rightIndex = middleIndex + 1;
            int auxIndex = left;
            while (leftIndex <= middleIndex && rightIndex <= right)
            {
                if (string.Compare(MyArray[leftIndex], MyArray[rightIndex], true) > 0)
                {
                    Aux[auxIndex] = MyArray[leftIndex++];

                }
                else
                {
                    Aux[auxIndex] = MyArray[rightIndex++];
                }
                auxIndex++;
            }
            while (leftIndex <= middleIndex)
            {
                Aux[auxIndex] = MyArray[leftIndex++];
                auxIndex++;
            }

            while (rightIndex <= right)
            {
                Aux[auxIndex] = MyArray[rightIndex++];
                auxIndex++;
            }
        }
    }
}

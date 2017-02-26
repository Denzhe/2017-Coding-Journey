using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
    class BubbleSorter : Sorter
    {
        public BubbleSorter(string[] MyArray) : base(MyArray)
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
            bool swapped = true;
            string temp = " ";

            do
            {
                swapped = false;

                for (var i = 0; i < MyArray.Length - 1; i++)
                {
                    if (string.Compare(MyArray[i],MyArray[i+1]) >= 0)
                    {
                        temp = MyArray[i];
                        MyArray[i] = MyArray[i + 1];
                        MyArray[i+1] = temp;
                        swapped = true;
                    }
                    
                }
            } while (swapped == true);

            this.watch.Stop();


        }
    }
}

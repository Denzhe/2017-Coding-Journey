using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm_v1
{
   abstract class Sorter
    {
        protected string[] MyArray;
        protected Stopwatch watch;


        public Sorter(string []MyArray)
        {
            this.MyArray = new string[MyArray.Length];
            MyArray.CopyTo(this.MyArray,0);
            this.watch = new Stopwatch();
        }

        public abstract void Sort();
        public abstract string [] Output();


        public void Swap(int First, int Second)
        {
            if (string.Compare(MyArray[First], MyArray[Second]) >= 0)
            {
                string tmp = MyArray[Second];
                MyArray[Second] = MyArray[First];
                MyArray[First] = tmp;
            }
                
        }

        public string TimeElpased()
        {
            return this.watch.Elapsed.ToString() + " ms";
        }
    }

}

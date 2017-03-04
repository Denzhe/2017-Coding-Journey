using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class Sorter
    {
        private object v;
        private BubbleOut bubbleOut;

        protected string[] MyArray { get; set; }

        ISort SortBehaviour { get; set; }

        IOutput OutputBehaviour { get; set; }



        public Sorter(string [] MyArray,ISort SortBehaviour, IOutput OutputBehaviour)
        {
            this.MyArray = new string[MyArray.Length];
            this.SortBehaviour = SortBehaviour;
            this.OutputBehaviour = OutputBehaviour;

        }

  
        public void Sort()
        {
            SortBehaviour.Sort(MyArray);
        }

        public string [] Output()
        {
          return  OutputBehaviour.Output(MyArray);
        }

        public void CallAlgorithm()
        {
            Sort();
            Output();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class Sorter
    {
        public ISort SortingBehaviour { get; set; }
        public IDisplay DisplayBehaviour { get; set; }

        public Sorter(ISort SortingBehaviour,IDisplay DisplayBehaviour)
        {
     
            this.SortingBehaviour = SortingBehaviour;
            this.DisplayBehaviour = DisplayBehaviour;
            
        }


        public void CallBehaviours(string[] myArray)
        {
            Sort(myArray);
            Display(myArray);
        }

        private void Display(string[] myArray)
        {
            DisplayBehaviour.Display(myArray);
        }

        public void Sort(string[] myArray)
        {
            SortingBehaviour.Sort(myArray);
        }
    }
}

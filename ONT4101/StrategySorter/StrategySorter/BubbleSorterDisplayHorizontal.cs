using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class BubbleSorterDisplayHorizontal : Sorter
    {
        public BubbleSorterDisplayHorizontal(string[] MyArray, ISort SortBehaviour, IOutput OutputBehaviour) : base(MyArray, SortBehaviour, OutputBehaviour)
        {

        }


    }
}

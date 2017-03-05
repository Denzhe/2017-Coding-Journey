using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class BubbleSorterDisplayHorizontal : Sorter
    {
        public BubbleSorterDisplayHorizontal(): base(new BSort (),new DisplayHorizontal() )
        {
        }
    }
}

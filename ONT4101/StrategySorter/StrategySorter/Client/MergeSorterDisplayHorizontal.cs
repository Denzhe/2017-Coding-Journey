using StrategySorter.Sort_Algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter.Client
{
    class MergeSorterDisplayHorizontal : Sorter
    {
        public MergeSorterDisplayHorizontal() : base(new MergeSort(),new DisplayVerticle())
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySorter
{
    class InsertionSorterDisplayVertical : Sorter
    {
        public InsertionSorterDisplayVertical() : base(new InsertSort(),new DisplayVerticle())
        {
        }
    }
}

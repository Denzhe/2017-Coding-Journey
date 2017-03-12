using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Sum : Genrator
    {

        int numberSum = 0;
        public Sum()
        {
            this.numberSum = getNumber() + number;
            

        }


        public int returnSum()
        {

            return this.numberSum;

        }


    }
}

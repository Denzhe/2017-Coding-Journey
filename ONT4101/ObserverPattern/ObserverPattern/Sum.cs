using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Sum
    {
        int sum = 0;
        Generator g = new Generator();


        public int setSum()
        {
           return this.sum += g.getRandom();

        }

     
    }
}

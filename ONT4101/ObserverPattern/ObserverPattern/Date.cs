using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Date
    {


         DateTime myDate = DateTime.Now;
         Generator g = new Generator();


        public DateTime setDate()
        {
           myDate = myDate.AddDays(g.getRandom());
            return myDate;

        }



 
    }
}

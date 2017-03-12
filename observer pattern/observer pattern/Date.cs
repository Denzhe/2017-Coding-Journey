using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class GetDate:Genrator
    {


        DateTime date = DateTime.Now;
        public GetDate()
        {
            this.date = this.date.AddDays(getNumber());


        }


        public DateTime returnDate()
        {

            return this.date;

        }

    }
}

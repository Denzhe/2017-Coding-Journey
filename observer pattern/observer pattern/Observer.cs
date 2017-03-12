using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Observer:IObserver
    {
        IGenerator generator;

        public Observer(Genrator generator)
        {

            this.generator = generator;
            this.generator.Attach(this);

        }

        public void update()
        {
            Sum sum = new Sum();
            int numSum = sum.returnSum();
            GetDate date = new GetDate();


            DateTime nowTime = date.returnDate();
            Console.WriteLine("Sum :" + numSum );

            Console.WriteLine("Date : " + nowTime);
        }
    }
}

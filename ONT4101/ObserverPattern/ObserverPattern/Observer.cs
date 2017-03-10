using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Observer : IObserver
    {
        ISubject TheSubject;

        public Observer(ISubject TheSubject)
        {
            this.TheSubject = TheSubject;
            this.TheSubject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Sum: " + ((Subject)this.TheSubject).getSum());
            Console.WriteLine("Date: " + ((Subject)this.TheSubject).getDate());

        }
    }
}

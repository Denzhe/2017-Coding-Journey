using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Subject : ISubject
    {
        List<IObserver> Observer = new List<IObserver>();

        Sum sum = new Sum();
        Date date = new Date();
        public void Attach(IObserver Target)
        {
            Observer.Add(Target);
        }

        public void Detach(IObserver Target)
        {

            Observer.Remove(Target);
        }

        public void Notify()
        {
            foreach (IObserver Current in Observer)
            {
                Current.Update();
            }
        }

      
        public void callMethod(int r)
        {
            Console.WriteLine("Sum: " + sum.setSum());
            Console.WriteLine("Date: " + date.setDate());
            Notify();
        }

      
    }
}

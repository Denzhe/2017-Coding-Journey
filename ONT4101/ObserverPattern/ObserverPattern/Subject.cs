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
        int sum = 0;
        DateTime myDate = DateTime.Now;
 
        
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

        public void setSum(int r)
        {
            this.sum += r;
           
        }

        public int getSum()
        {
            return this.sum;
        }

        public void setDate(int r)
        {
            myDate = myDate.AddDays(r);
          
           
        }


        public void callMethod(int r)
        {
            setSum(r);
            setDate(r);
            Notify();
        }

        public DateTime getDate()
        {
            return this.myDate;
        }
    }
}

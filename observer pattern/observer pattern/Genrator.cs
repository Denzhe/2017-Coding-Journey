using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Genrator: IGenerator
    {
        static Random rnd = new Random();
        public int number = 0;
        List <IObserver> Observers = new List <IObserver>();

      


        public void Detach(IObserver Target)
        {
            Observers.Remove(Target);
                
        }
        public void Attach(IObserver Target)
        {
            Observers.Add(Target);

        }

        public void Notify()
        {
            foreach (IObserver i in Observers)
                i.update();

        }


        public int getNumber()
        {
            this.number = rnd.Next(1, 1001);
            return this.number;

        }


      
    }
}

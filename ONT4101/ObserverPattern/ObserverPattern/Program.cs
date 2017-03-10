using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject TheSubject = new Subject();

            Generator g = new Generator();

            List<IObserver> mySubs = new List<IObserver>
            {
              new Observer(TheSubject)
            };

            ConsoleKeyInfo myKey;


            Console.Title = "Press E to escape";

           

            do
            {



                foreach (IObserver current in mySubs)
                {
                    TheSubject.callMethod(g.getRandom());
                }

                Console.WriteLine();

                myKey = Console.ReadKey();

               
            } while (myKey.Key != ConsoleKey.E);
            

            Console.ReadLine();
        }


    }
}

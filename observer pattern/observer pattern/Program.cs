using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Genrator gen = new Genrator();
            IObserver firstSubscriber = new Observer(gen);
            firstSubscriber.update();
            IObserver secondSubscriber = new Observer(gen);
            secondSubscriber.update();

            IObserver thirdSubscriber = new Observer(gen);
            thirdSubscriber.update();
            Console.ReadLine();


            ConsoleKeyInfo key;
            key = Console.ReadKey();
            while (key.Key != ConsoleKey.E) {

                firstSubscriber.update();
                secondSubscriber.update();
                thirdSubscriber.update();

            }

            Console.ReadLine();

        }
    }
}

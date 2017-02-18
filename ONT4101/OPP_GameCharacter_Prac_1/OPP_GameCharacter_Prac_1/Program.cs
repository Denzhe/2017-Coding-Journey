using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_GameCharacter_Prac_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Press E to exit";


            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{

            //    Console.SetCursorPosition(0, 0);
            //    Console.WriteLine(Console.LargestWindowHeight.ToString() + "\t" + Console.LargestWindowWidth.ToString());
            //    Console.ReadLine();

            //}

            List<GameCharacter> myGame = new List<GameCharacter>
            {
                new HorizontalMover(0, 20, "#"),
                new HorizontalMover(0,2,"%"),
                new VerticalMover(20,11,"^"),
                new VerticalMover(20,10,"&")

            };

            ConsoleKeyInfo keyInfo;

            do
            {
               

                foreach (GameCharacter item in myGame)
                {
                    Console.SetCursorPosition(item.CurrentX,item.CurrentY);
                    Console.WriteLine(item.ToString());
                }

                keyInfo = Console.ReadKey();
            } while (keyInfo.Key!= ConsoleKey.E );

          
        }

       
    }
}

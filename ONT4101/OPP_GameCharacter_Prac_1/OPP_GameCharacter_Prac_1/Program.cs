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

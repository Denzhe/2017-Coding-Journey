using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Learning_Game
{
    class Program
    {
       static BTTree tree;
        static void Main(string[] args)
        {
            StartNewGame();
            Console.WriteLine("\nStarting the Game");
            tree.Query();
            while (PlayAgain())
            {
                Console.WriteLine();
                tree.Query();
            }

            Console.WriteLine("Thanks or playing ");
            Console.ReadLine();

        }

         static bool PlayAgain()
        {
            Console.Write("\nPlay Another Game? ");
            char inputChar = Console.ReadLine().ElementAt(0);
            inputChar = char.ToLower(inputChar);

            while (inputChar != 'y' && inputChar != 'n')
            {
                Console.WriteLine("Incorrect input please try again: ");
                inputChar = Console.ReadLine().ElementAt(0);
                inputChar = char.ToLower(inputChar);
            }

            if (inputChar == 'y')
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        static void StartNewGame()
        {
            Console.WriteLine("No Previous knowledge found!");
            Console.WriteLine("Initializing a new game.\n");
            Console.Write("Enter a question about an object: ");
            string question = Console.ReadLine();
            Console.Write("Enter a guess if the response is Yes: ");
            string yesGuess = Console.ReadLine();
            Console.Write("Enter a guess if the response is No: ");
            string noGuess = Console.ReadLine();

            tree = new BTTree(question, yesGuess, noGuess);

        }
    }
}

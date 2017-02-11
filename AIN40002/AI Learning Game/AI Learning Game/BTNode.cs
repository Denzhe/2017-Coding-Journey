using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Learning_Game
{
    [Serializable]
    class BTNode
    {
        string message;
        BTNode noNode;
        BTNode yesNode;

        int playerWin;
        int computerWin;

        public BTNode(string nodeMessage)
        {
            message = nodeMessage;
            noNode = null;
            yesNode = null;
            playerWin = 0;
            computerWin = 0;
        }


        //Properties

        public string Message
        {
            get => message;
            set => message = value;
        }

        public BTNode NoNode
        {
            get => noNode;
            set => noNode = value;
        }

        public BTNode YesNode
        {
            get => yesNode;
            set => yesNode = value;
        }

        public int PlayerWin
        {
            get => playerWin;
            set => playerWin = value;
        }

        public int ComputerWin
        {
            get => computerWin;
            set => computerWin = value;
        }

        public bool IsQuestion()
        {
            return noNode == null && yesNode == null ? false : true;
        }


        private char GetYesOrNo()
        {
            Console.WriteLine("\n Enter 'y' for yes and 'n' for no: ");

            char inputChar = ' ';

            while (inputChar != 'y' && inputChar != 'n')
            {
                inputChar = Console.ReadLine().ElementAt(0);
                inputChar = char.ToLower(inputChar);

                if (inputChar != 'y' && inputChar != 'n')
                    Console.WriteLine("Incorrect input please enter again: ");
            }

            return inputChar;
        }


        public void Query()
        {

        }

    }
}

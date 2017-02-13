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

        public void SetMessage(string nodeMessage)
        {
            message = nodeMessage;
        }

        public string GetMessage()
        {
            return message;
        }

        public void SetNoNode(BTNode node)
        {
            noNode = node;
        }

        public BTNode GetNoNode()
        {
            return noNode;
        }


        public void SetYesNode(BTNode node)
        {
            yesNode = node;
        }

        public BTNode GetYesNode()
        {
            return yesNode;
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
            if (this.IsQuestion())
            {
                Console.WriteLine(this.message);

                char input = GetYesOrNo();

                if (input == 'y')
                {
                    yesNode.Query();
                    playerWin++;
                }
                else
                {
                    noNode.Query();
                    computerWin++;
                }

            }
            else
                this.OnQueryObject();
        }

        public void OnQueryObject()
        {
            Console.WriteLine("Are you thinking of a(n) " + this.message + "?");

            char input = GetYesOrNo();
            if (input == 'y')
            {
                Console.Write("The Computer Wins\n");
            }
            else
            {
                UpdateTree();
            }

        }

        private void UpdateTree()
        {
            Console.Write("You win! What was the correct answer?");
            string userObject = Console.ReadLine();

            Console.Write("Please enter a question to a(n) " + this.message + " from " + userObject + " : ");
            string userQuestion = Console.ReadLine();

            Console.Write("If you were thinking of a(n) " + userObject + ", what would the answer to that question be?");
            char input = GetYesOrNo();
            if (input == 'y')
            {
                this.noNode = new BTNode(this.message);
                this.yesNode = new BTNode(userObject);
            }

            else
            {
                this.yesNode = new BTNode(this.message);
                this.noNode = new BTNode(userObject);
            }

            Console.Write("Thanks you to I'm getting way smarter");
            this.SetMessage(userQuestion);
        }

      
    }
}

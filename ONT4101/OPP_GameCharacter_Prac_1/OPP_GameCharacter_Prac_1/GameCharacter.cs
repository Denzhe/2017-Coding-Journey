using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_GameCharacter_Prac_1
{
  abstract public class GameCharacter
    {
        public const int maxWidthArea = 300;
        public const int maxheightArea = 300;

        protected int currentX;//horizontal move
        protected int currentY;//Vertical Move
        private string symbol;

        
        public string Symbol
        {
            get { return symbol; }
        }
        public int CurrentX
        {
            get { return currentX; }
        }


        public int CurrentY
        {
            get { return currentY; }
        }
        public GameCharacter(int currentX, int currentY,string symbol)
        {
            this.currentX = currentX;
            this.currentY = currentY;
            this.symbol = symbol;
        }


        public abstract void Move();
       

        public bool Draw(int DrawX,int DrawY)
        {
            bool found = true;
            if (currentX == DrawX && currentY == DrawY)
            {
                Console.SetCursorPosition(currentX + DrawX, currentY + DrawY);
                Console.Write(symbol);
                found = true;
            }

            else
            {
                found = false;
            }


            return found;

        }


        public override string ToString()
        {
            return $"{symbol} {currentX} , {currentY} {GetType().Name}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_GameCharacter_Prac_1
{
    public class GameCharacter
    {
        public const int maxWidthArea = 300;
        public const int maxheightArea = 300;

        protected int currentX;
        protected int currentY;
        private string symbol;

        

        public GameCharacter(int currentX, int currentY,string symbol)
        {
            this.currentX = currentX;
            this.currentY = currentY;
            this.symbol = symbol;
        }

   


    }
}

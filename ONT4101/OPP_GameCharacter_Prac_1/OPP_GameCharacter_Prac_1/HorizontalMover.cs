using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_GameCharacter_Prac_1
{
    class HorizontalMover : GameCharacter
    {

        private bool moveRight;

        public HorizontalMover(int currentX, int currentY, string symbol) : base(currentX, currentY, symbol)
        {
        }


        public override void Move()
        {
            if (moveRight)
            {
                this.currentX++;
                moveRight = true;
               
            }

            else
            {
                this.currentX--;
                moveRight = false;
            }
        }


    }
}

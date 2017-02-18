using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_GameCharacter_Prac_1
{
    class VerticalMover : GameCharacter
    {

        private bool moveDown;

        public VerticalMover(int currentX, int currentY, string symbol) : base(currentX, currentY, symbol)
        {

        }

        public override void Move()
        {

            if (moveDown)
            {
                this.currentY++;
                moveDown = true;
            }
            else
            {
                this.currentY--;
                moveDown = false;
            }
        }
    }
}

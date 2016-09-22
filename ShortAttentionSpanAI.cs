using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        public int plannedMove = -1;

        public int NextMove()
        {
            if (plannedMove < 0)
            {
                Random rand = new Random();
                return rand.Next(3);
            }
            else
            {
                return plannedMove;
            }
        }

        public void SaveResult(int myMove, int otherMove)
        {
            if (otherMove == 0)
            {
                plannedMove = 1;
            }
            else if (otherMove == 1)
            {
                plannedMove = 2;
            }
            else if (otherMove == 2)
            {
                plannedMove = 0;
            }
        }
    }
}

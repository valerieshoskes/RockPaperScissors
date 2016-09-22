using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        public int plannedMove = -1;
        public int NextMove()
        {
            if (plannedMove < 0)
            {
                Random rand = new Random();
                plannedMove = rand.Next(3);
            }
            return plannedMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            // not needed for this AI
        }
    }
}

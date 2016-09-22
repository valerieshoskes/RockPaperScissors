using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        public int NextMove()
        {
            Random rand = new Random();
            return rand.Next(3);
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //does nothing
        }
    }
}

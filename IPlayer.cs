using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    interface IPlayer
    {
        /// <summary>
        /// Gets the next move for this player
        /// </summary>
        /// <returns>0 for rock, 1 for paper, 2 for scissors</returns>
        int NextMove();

        /// <summary>
        /// A method to allow the player to keep track of previous moves.
        /// Some implementations may not actually do anything with this method.
        /// </summary>
        /// <param name="myMove">what I played (0 for rock, 1 for paper, 2 for scissors)</param>
        /// <param name="otherMove">what the opponent played (0 for rock, 1 for paper, 2 for scissors)</param>
        void SaveResult(int myMove, int otherMove);
    }
}

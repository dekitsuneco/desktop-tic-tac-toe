using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    /// <summary>
    /// This class describes the logic of user move's realisation.
    /// </summary>
    class Player
    {
        /// <summary>
        /// The method notes the user's move into gamefield array,
        /// and deliver the turn to AI.
        /// </summary>
        public static void MakeUserMove(int x, int y)
        {
            
            GameController.gameField[x, y] = 2;
            GameController.xOfCurrentMove = x;
            GameController.yOfCurrentMove = y;
            if (GameController.xOfPreviousMove < 0 && GameController.yOfPreviousMove < 0)
            {
                GameController.xOfPreviousMove = x;
                GameController.yOfPreviousMove = y;
            }

            GameController.isNowAIMove = true;
        }
    }
}
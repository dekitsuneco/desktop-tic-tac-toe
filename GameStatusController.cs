using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    /// <summary>
    /// This class describes the game status after one full move,
    /// - check if the AI is winning right now or is game draw.
    /// </summary>
    class GameStatusController
    {
        public static void CheckIfAIWins()
        {
            // Check the first row if the AI already has taken two squares there.
            // In that case, make a victory move to the free square in this row.
            if (((GameController.gameField[0, 0] +
                GameController.gameField[0, 1] +
                GameController.gameField[0, 2]) == 2)
                &&
                (GameController.gameField[0, 0] == 1 ||
                GameController.gameField[0, 1] == 1 ||
                GameController.gameField[0, 2] == 1))
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameController.gameField[0, j] == 0)
                    {
                        GameController.gameField[0, j] = 1;

                        Drawer.PaintAIMove(0, j);
                    }
                }
                GameController.whoIsWinner = GameController.WhoseVictory.AI;

                GameController.line = 4;
            }
            else
            {
                if (((GameController.gameField[1, 0] +
                    GameController.gameField[1, 1] +
                    GameController.gameField[1, 2]) == 2)
                    &&
                    (GameController.gameField[1, 0] == 1 ||
                    GameController.gameField[1, 1] == 1 ||
                    GameController.gameField[1, 2] == 1))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (GameController.gameField[1, j] == 0)
                        {
                            GameController.gameField[1, j] = 1;
                            Drawer.PaintAIMove(1, j);
                        }
                    }
                    GameController.whoIsWinner = GameController.WhoseVictory.AI;

                    GameController.line = 5;
                }
                else
                {
                    if (((GameController.gameField[2, 0] +
                        GameController.gameField[2, 1] +
                        GameController.gameField[2, 2]) == 2)
                        &&
                        (GameController.gameField[2, 0] == 1 ||
                        GameController.gameField[2, 1] == 1 ||
                        GameController.gameField[2, 2] == 1))
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (GameController.gameField[2, j] == 0)
                            {
                                GameController.gameField[2, j] = 1;
                                Drawer.PaintAIMove(2, j);
                            }
                        }
                        GameController.whoIsWinner = GameController.WhoseVictory.AI;

                        GameController.line = 6;
                    }
                    else
                    {
                        if (((GameController.gameField[0, 0] +
                            GameController.gameField[1, 0] +
                            GameController.gameField[2, 0]) == 2)
                            &&
                            (GameController.gameField[0, 0] == 1 ||
                            GameController.gameField[1, 0] == 1 ||
                            GameController.gameField[2, 0] == 1))
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (GameController.gameField[i, 0] == 0)
                                {
                                    GameController.gameField[i, 0] = 1;
                                    Drawer.PaintAIMove(i, 0);
                                }
                            }
                            GameController.whoIsWinner = GameController.WhoseVictory.AI;

                            GameController.line = 1;
                        }
                        else
                        {
                            if (((GameController.gameField[0, 1] +
                                GameController.gameField[1, 1] +
                                GameController.gameField[2, 1]) == 2)
                                &&
                                (GameController.gameField[0, 1] == 1 ||
                                GameController.gameField[1, 1] == 1 ||
                                GameController.gameField[2, 1] == 1))
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (GameController.gameField[i, 1] == 0)
                                    {
                                        GameController.gameField[i, 1] = 1;
                                        Drawer.PaintAIMove(i, 1);
                                    }
                                }
                                GameController.whoIsWinner = GameController.WhoseVictory.AI;

                                GameController.line = 2;
                            }
                            else
                            {
                                if (((GameController.gameField[0, 2] +
                                    GameController.gameField[1, 2] +
                                    GameController.gameField[2, 2]) == 2)
                                    &&
                                    (GameController.gameField[0, 2] == 1 ||
                                    GameController.gameField[1, 2] == 1 ||
                                    GameController.gameField[2, 2] == 1))
                                {
                                    for (int i = 0; i < 3; i++)
                                    {
                                        if (GameController.gameField[i, 2] == 0)
                                        {
                                            GameController.gameField[i, 2] = 1;
                                            Drawer.PaintAIMove(i, 2);
                                        }
                                    }
                                    GameController.whoIsWinner = GameController.WhoseVictory.AI;

                                    GameController.line = 3;
                                }
                                else
                                {
                                    if (((GameController.gameField[0, 0] +
                                        GameController.gameField[1, 1] +
                                        GameController.gameField[2, 2]) == 2)
                                        &&
                                        (GameController.gameField[0, 0] == 1 ||
                                        GameController.gameField[1, 1] == 1 ||
                                        GameController.gameField[2, 2] == 1))
                                    {
                                        if (GameController.gameField[0, 0] == 0)
                                        {
                                            GameController.gameField[0, 0] = 1;
                                            Drawer.PaintAIMove(0, 0);
                                        }
                                        if (GameController.gameField[1, 1] == 0)
                                        {
                                            GameController.gameField[1, 1] = 1;
                                            Drawer.PaintAIMove(1, 1);
                                        }
                                        if (GameController.gameField[2, 2] == 0)
                                        {
                                            GameController.gameField[2, 2] = 1;
                                            Drawer.PaintAIMove(2, 2);
                                        }
                                        GameController.whoIsWinner = GameController.WhoseVictory.AI;

                                        GameController.line = 7;
                                    }
                                    else
                                    {
                                        if (((GameController.gameField[2, 0] +
                                            GameController.gameField[1, 1] +
                                            GameController.gameField[0, 2]) == 2)
                                            &&
                                            (GameController.gameField[2, 0] == 1 ||
                                            GameController.gameField[1, 1] == 1 ||
                                            GameController.gameField[0, 2] == 1))
                                        {
                                            if (GameController.gameField[2, 0] == 0)
                                            {
                                                GameController.gameField[2, 0] = 1;
                                                Drawer.PaintAIMove(2, 0);
                                            }
                                            if (GameController.gameField[1, 1] == 0)
                                            {
                                                GameController.gameField[1, 1] = 1;
                                                Drawer.PaintAIMove(1, 1);
                                            }
                                            if (GameController.gameField[0, 2] == 0)
                                            {
                                                GameController.gameField[0, 2] = 1;
                                                Drawer.PaintAIMove(0, 2);
                                            }
                                            GameController.whoIsWinner = GameController.WhoseVictory.AI;

                                            GameController.line = 8;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void CheckIfGameFieldIsFull()
        {
            int filledSquare = 0;
            for (int c = 0; c < 3; c++)
            {
                for (int r = 0; r < 3; r++)
                {
                    if (GameController.gameField[c, r] > 0)
                    {
                        filledSquare++;
                    }
                }
            }
            if (filledSquare == 9)
            {
                GameController.RenderGameOverMessage();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KrestikiNoliki
{
    /// <summary>
    /// This class is responsible for AI.
    /// All things related to the how of it's making decicions here.
    /// </summary>
    class ArtificialIntelligence : Form
    {
        /// <summary>
        /// Here AI make a move to a square
        /// in the case if two others in the row is already taken by user.
        /// </summary>
        public void DefendFromUser()
        {
            // Проверяем первую строку на наличие двух уже сделанных ходов со стороны Ирока.
            // И в таком случае, делаем защитный ход в третью свободную в ряду клетку.
            if ((GameController.gameField[0, 0] +
                GameController.gameField[0, 1] +
                GameController.gameField[0, 2]) == 4
                &&
                GameController.gameField[0, 0] != 1 &&
                GameController.gameField[0, 1] != 1 &&
                GameController.gameField[0, 2] != 1)   
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameController.gameField[0, j] == 0)
                    {
                        GameController.gameField[0, j] = 1;
                        Drawer.PaintAIMove(0, j);
                        GameController.isNowAIMove = false;
                    }
                }
            }
            else
            {
                if ((GameController.gameField[1, 0] +
                    GameController.gameField[1, 1] +
                    GameController.gameField[1, 2]) == 4
                    &&
                    GameController.gameField[1, 0] != 1 &&
                    GameController.gameField[1, 1] != 1 &&
                    GameController.gameField[1, 2] != 1)   
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (GameController.gameField[1, j] == 0)
                        {
                            GameController.gameField[1, j] = 1;
                            Drawer.PaintAIMove(1, j);
                            GameController.isNowAIMove = false;
                        }
                    }
                }
                else
                {
                    if ((GameController.gameField[2, 0] +
                        GameController.gameField[2, 1] +
                        GameController.gameField[2, 2]) == 4
                        && 
                        GameController.gameField[2, 0] != 1 &&
                        GameController.gameField[2, 1] != 1 &&
                        GameController.gameField[2, 2] != 1)   
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (GameController.gameField[2, j] == 0)
                            {
                                GameController.gameField[2, j] = 1;
                                Drawer.PaintAIMove(2, j);
                                GameController.isNowAIMove = false;
                            }
                        }
                    }
                    else
                    {
                        if ((GameController.gameField[0, 0] +
                            GameController.gameField[1, 0] +
                            GameController.gameField[2, 0]) == 4
                            &&
                            GameController.gameField[0, 0] != 1 &&
                            GameController.gameField[1, 0] != 1 &&
                            GameController.gameField[2, 0] != 1)   
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (GameController.gameField[i, 0] == 0)
                                {
                                    GameController.gameField[i, 0] = 1;
                                    Drawer.PaintAIMove(i, 0);
                                    GameController.isNowAIMove = false;
                                }
                            }
                        }
                        else
                        {
                            if ((GameController.gameField[0, 1] +
                                GameController.gameField[1, 1] +
                                GameController.gameField[2, 1]) == 4
                                &&
                                GameController.gameField[0, 1] != 1 &&
                                GameController.gameField[1, 1] != 1 &&
                                GameController.gameField[2, 1] != 1)  
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (GameController.gameField[i, 1] == 0)
                                    {
                                        GameController.gameField[i, 1] = 1;
                                        Drawer.PaintAIMove(i, 1);
                                        GameController.isNowAIMove = false;
                                    }
                                }
                            }
                            else
                            {
                                if ((GameController.gameField[0, 2] +
                                    GameController.gameField[1, 2] +
                                    GameController.gameField[2, 2]) == 4
                                    &&
                                    GameController.gameField[0, 2] != 1 &&
                                    GameController.gameField[1, 2] != 1 &&
                                    GameController.gameField[2, 2] != 1)  
                                {
                                    for (int i = 0; i < 3; i++)
                                    {
                                        if (GameController.gameField[i, 2] == 0)
                                        {
                                            GameController.gameField[i, 2] = 1;
                                            Drawer.PaintAIMove(i, 2);
                                            GameController.isNowAIMove = false;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((GameController.gameField[0, 0] +
                                        GameController.gameField[1, 1] +
                                        GameController.gameField[2, 2]) == 4
                                        &&
                                        GameController.gameField[0, 0] != 1 &&
                                        GameController.gameField[1, 1] != 1 &&
                                        GameController.gameField[2, 2] != 1)   
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
                                        GameController.isNowAIMove = false;
                                    }
                                    else
                                    {
                                        if ((GameController.gameField[2, 0] +
                                            GameController.gameField[1, 1] +
                                            GameController.gameField[0, 2]) == 4
                                            &&
                                            GameController.gameField[2, 0] != 1 &&
                                            GameController.gameField[1, 1] != 1 &&
                                            GameController.gameField[0, 2] != 1)   
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
                                            GameController.isNowAIMove = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Main logical part.
        /// </summary>
        public void MoveToFarthestAngle()
        {
            DefendCenterSideSquares();
            if (GameController.isNowAIMove == false)
            {
                return;
            }
            DefendFromFokes();
            if (GameController.isNowAIMove == false)
            {
                return;
            }

            if (GameController.xOfCurrentMove == 0 &&
                GameController.yOfCurrentMove == 0) 
            {
                if (GameController.gameField[2, 2] == 0)
                {
                    GameController.gameField[2, 2] = 1;
                    Drawer.PaintAIMove(2, 2);
                    GameController.isNowAIMove = false;
                }
                else
                {
                    MakeRandomMove();
                }
            }
            else
            {
                if (GameController.xOfCurrentMove == 2 &&
                    GameController.yOfCurrentMove == 0) 
                {
                    if (GameController.gameField[0, 2] == 0)
                    {
                        GameController.gameField[0, 2] = 1;
                        Drawer.PaintAIMove(0, 2);
                        GameController.isNowAIMove = false;
                    }
                    else
                    {
                        MakeRandomMove();
                    }
                }
                else
                {
                    if (GameController.xOfCurrentMove == 0 &&
                        GameController.yOfCurrentMove == 2) 
                    {
                        if (GameController.gameField[2, 0] == 0)
                        {
                            GameController.gameField[2, 0] = 1;
                            Drawer.PaintAIMove(2, 0);
                            GameController.isNowAIMove = false;
                        }
                        else
                        {
                            MakeRandomMove();
                        }
                    }
                    else
                    {
                        if (GameController.xOfCurrentMove == 2 &&
                            GameController.yOfCurrentMove == 2) 
                        {
                            if (GameController.gameField[0, 0] == 0)
                            {
                                GameController.gameField[0, 0] = 1;
                                Drawer.PaintAIMove(0, 0);
                                GameController.isNowAIMove = false;
                            }
                            else
                            {
                                MakeRandomMove();
                            }
                        }
                        else
                        {
                            if (GameController.xOfCurrentMove == 0 &&
                                GameController.yOfCurrentMove == 1) 
                            {
                                if (GameController.gameField[2, 0] == 0)
                                {
                                    GameController.gameField[2, 0] = 1;
                                    Drawer.PaintAIMove(2, 0);
                                    GameController.isNowAIMove = false;
                                }
                                else
                                {
                                    if (GameController.gameField[2, 2] == 0)
                                    {
                                        GameController.gameField[2, 2] = 1;
                                        Drawer.PaintAIMove(2, 2);
                                        GameController.isNowAIMove = false;
                                    }
                                    else
                                    {
                                        MakeRandomMove();
                                    }
                                }
                            }
                            else
                            {
                                if (GameController.xOfCurrentMove == 1 &&
                                    GameController.yOfCurrentMove == 0) 
                                {
                                    if (GameController.gameField[0, 2] == 0)
                                    {
                                        GameController.gameField[0, 2] = 1;
                                        Drawer.PaintAIMove(0, 2);
                                        GameController.isNowAIMove = false;
                                    }
                                    else
                                    {
                                        if (GameController.gameField[2, 2] == 0)
                                        {
                                            GameController.gameField[2, 2] = 1;
                                            Drawer.PaintAIMove(2, 2);
                                            GameController.isNowAIMove = false;
                                        }
                                        else
                                        {
                                            MakeRandomMove();
                                        }
                                    }
                                }
                                else
                                {
                                    if (GameController.xOfCurrentMove == 2 &&
                                        GameController.yOfCurrentMove == 1) 
                                    {
                                        if (GameController.gameField[0, 0] == 0)
                                        {
                                            GameController.gameField[0, 0] = 1;
                                            Drawer.PaintAIMove(0, 0);
                                            GameController.isNowAIMove = false;
                                        }
                                        else
                                        {
                                            if (GameController.gameField[0, 2] == 0)
                                            {
                                                GameController.gameField[0, 2] = 1;
                                                Drawer.PaintAIMove(0, 2);
                                                GameController.isNowAIMove = false;
                                            }
                                            else
                                            {
                                                MakeRandomMove();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (GameController.xOfCurrentMove == 1 &&
                                            GameController.yOfCurrentMove == 2) 
                                        {
                                            if (GameController.gameField[0, 0] == 0)
                                            {
                                                GameController.gameField[0, 0] = 1;
                                                Drawer.PaintAIMove(0, 0);
                                                GameController.isNowAIMove = false;
                                            }
                                            else
                                            {
                                                if (GameController.gameField[2, 0] == 0)
                                                {
                                                    GameController.gameField[2, 0] = 1;
                                                    Drawer.PaintAIMove(2, 0);
                                                    GameController.isNowAIMove = false;
                                                }
                                                else
                                                {
                                                    MakeRandomMove();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// If two the closest central and side squares are taken by user,
        /// make a move to the angle square among them.
        /// </summary>
        public void DefendCenterSideSquares()
        {
            if (GameController.gameField[0, 1] == 2)
            {
                if (GameController.gameField[1, 0] == 2 &&
                    GameController.gameField[0, 0] == 0)
                {
                    GameController.gameField[0, 0] = 1;
                    Drawer.PaintAIMove(0, 0);
                    GameController.isNowAIMove = false;
                }
                else if (GameController.gameField[1, 2] == 2 &&
                    GameController.gameField[0, 2] == 0)
                {
                    GameController.gameField[0, 2] = 1;
                    Drawer.PaintAIMove(0, 2);
                    GameController.isNowAIMove = false;
                }
            }
            else if (GameController.gameField[2, 1] == 2)
            {
                if (GameController.gameField[1, 0] == 2 &&
                    GameController.gameField[2, 0] == 0)
                {
                    GameController.gameField[2, 0] = 1;
                    Drawer.PaintAIMove(2, 0);
                    GameController.isNowAIMove = false;
                }
                else if (GameController.gameField[1, 2] == 2 &&
                    GameController.gameField[2, 2] == 0)
                {
                    GameController.gameField[2, 2] = 1;
                    Drawer.PaintAIMove(2, 2);
                    GameController.isNowAIMove = false;
                }
            }
        }

        /// <summary>
        /// Protection from "fork".
        /// </summary>
        public void DefendFromFokes()
        {
            if (GameController.gameField[0, 0] == 2 &&
                GameController.gameField[2, 1] == 2 &&
                GameController.gameField[1, 0] == 0) 
            {
                GameController.gameField[1, 0] = 1;
                Drawer.PaintAIMove(1, 0);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[0, 0] == 2 &&
                GameController.gameField[1, 2] == 2 &&
                GameController.gameField[0, 1] == 0) 
            {
                GameController.gameField[0, 1] = 1;
                Drawer.PaintAIMove(0, 1);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[0, 2] == 2 &&
                GameController.gameField[2, 1] == 2 &&
                GameController.gameField[1, 2] == 0) 
            {
                GameController.gameField[1, 2] = 1;
                Drawer.PaintAIMove(1, 2);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[0, 2] == 2 &&
                GameController.gameField[1, 0] == 2 &&
                GameController.gameField[0, 1] == 0) 
            {
                GameController.gameField[0, 1] = 1;
                Drawer.PaintAIMove(0, 1);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[2, 2] == 2 &&
                GameController.gameField[1, 0] == 2 &&
                GameController.gameField[2, 1] == 0) 
            {
                GameController.gameField[2, 1] = 1;
                Drawer.PaintAIMove(2, 1);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[2, 2] == 2 &&
                GameController.gameField[0, 1] == 2 &&
                GameController.gameField[1, 2] == 0) 
            {
                GameController.gameField[1, 2] = 1;
                Drawer.PaintAIMove(1, 2);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[2, 0] == 2 &&
                GameController.gameField[1, 2] == 2 &&
                GameController.gameField[2, 1] == 0) 
            {
                GameController.gameField[2, 1] = 1;
                Drawer.PaintAIMove(2, 1);
                GameController.isNowAIMove = false;
            }
            else if (GameController.gameField[2, 0] == 2 &&
                GameController.gameField[0, 1] == 2 &&
                GameController.gameField[1, 0] == 0) 
            {
                GameController.gameField[1, 0] = 1;
                Drawer.PaintAIMove(1, 0);
                GameController.isNowAIMove = false;
            }
        }

        /// <summary>
        /// Search any free angle and make move there,
        /// if it's impossibe, just move to the first free square.
        /// </summary>
        public void MoveToFreeAngle()
        {
            if (GameController.gameField[0, 0] == 0)
            {
                GameController.gameField[0, 0] = 1;
                Drawer.PaintAIMove(0, 0);
                GameController.isNowAIMove = false;
            }
            else
            {
                if (GameController.gameField[2, 0] == 0)
                {
                    GameController.gameField[2, 0] = 1;
                    Drawer.PaintAIMove(2, 0);
                    GameController.isNowAIMove = false;
                }
                else
                {
                    if (GameController.gameField[0, 2] == 0)
                    {
                        GameController.gameField[0, 2] = 1;
                        Drawer.PaintAIMove(0, 2);
                        GameController.isNowAIMove = false;
                    }
                    else
                    {
                        if (GameController.gameField[2, 2] == 0)
                        {
                            /*
                             Если хотим сделать ИИ не непобедимым.
                             В данном случае он примет не оптимальный ход.
                             MakeRandomMove();
                             */
                            GameController.gameField[2, 2] = 1;
                            Drawer.PaintAIMove(2, 2);
                            GameController.isNowAIMove = false;
                        }
                        else
                        {
                            MakeRandomMove();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Make a move to the center.
        /// </summary>
        public void MoveToCenter()
        {
            bool isCenterSquareFree = GameController.gameField[1, 1] == 0;
            if (isCenterSquareFree)
            {
                GameController.gameField[1, 1] = 1;
                Drawer.PaintAIMove(1, 1);
                GameController.isNowAIMove = false;
            }
            else
            {
                MoveToFreeAngle();
            }
        }

        /// <summary>
        /// Make a random move.
        /// </summary>
        public void MakeRandomMove()
        {
            // Check if the square is free and then move to it.
            // First of all, check all central side ones,
            // if they're all taken, move to the first free.
            bool wasCenterSideSquareFree = false;
            if (GameController.gameField[0, 1] == 0)
            {
                GameController.gameField[0, 1] = 1;
                Drawer.PaintAIMove(0, 1);
                GameController.isNowAIMove = false;
                wasCenterSideSquareFree = true;
                return;
            }
            else if (GameController.gameField[1, 0] == 0)
            {
                GameController.gameField[1, 0] = 1;
                Drawer.PaintAIMove(1, 0);
                GameController.isNowAIMove = false;
                wasCenterSideSquareFree = true;
                return;
            }
            else if (GameController.gameField[1, 2] == 0)
            {
                GameController.gameField[1, 2] = 1;
                Drawer.PaintAIMove(1, 2);
                GameController.isNowAIMove = false;
                wasCenterSideSquareFree = true;
                return;
            }
            else if (GameController.gameField[2, 1] == 0)
            {
                GameController.gameField[2, 1] = 1;
                Drawer.PaintAIMove(2, 1);
                GameController.isNowAIMove = false;
                wasCenterSideSquareFree = true;
                return;
            }

            if (!wasCenterSideSquareFree)
            {
                bool flag = true;
                for (int i = 0; flag && i < 3; i++)
                {
                    for (int j = 0; flag && j < 3; j++)
                    {
                        if (GameController.gameField[i, j] == 0)
                        {
                            GameController.gameField[i, j] = 1;
                            Drawer.PaintAIMove(i, j);
                            GameController.isNowAIMove = false;
                            flag = false;
                            return;
                        }
                    }
                }
            }

            return;
        }
    }
}
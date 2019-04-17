using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNoliki
{
    /// <summary>
    /// This class describes the game logic, - how to make moves etc.
    /// </summary>
    public partial class GameController : Form
    {
        public GameController()
        {
            InitializeComponent();
        }

        #region [[[ Initializing vars ]]]
        ArtificialIntelligence ai;

        public enum WhoseMove: int
        {
            Undefined,
            AI,
            User
        }
        public enum WhoseVictory: int
        {
            Draw,
            AI,
            User
        }
        public static WhoseVictory whoIsWinner = WhoseVictory.Draw;
        public static WhoseMove whoFirstMoved = WhoseMove.Undefined;
        public static bool doesUserMoveFirst = false;
        public static bool isNowAIMove = false;
        public static int[,] gameField = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        
        public static int line = 0;       
        
        public static int xOfPreviousMove = -1;    
        public static int yOfPreviousMove = -1;    
        public static int xOfCurrentMove = 0;    
        public static int yOfCurrentMove = 0; 

        public static bool wasGameInitialized = false;
        public static bool isGameOver = false;
        #endregion [[[ Initializing vars ]]]

        /// <summary>
        /// The method sends an example of this class to Drawer.
        /// It was done in order to allow Drawer work with winform panels.
        /// </summary>
        public void SendPanelsToDrawer()
        {
            Drawer.DefinePanels(this);
        }
        /// <summary>
        /// Make all preparations to the game done.
        /// </summary>
        public void StartGame(object sender, EventArgs e)
        {
            ResetStartConditions();

            if (checkboxAIPlayFirst.Checked)
            {
                GameController.isNowAIMove = true;
                GameController.whoFirstMoved = WhoseMove.AI;
                GameController.doesUserMoveFirst = false;
            }

            if (!GameController.doesUserMoveFirst)
            {
                RealizeGameAlgorithm();
            }

            wasGameInitialized = true;
        }
        
        /// <summary>
        /// Reset all variables.
        /// </summary>
        public void ResetStartConditions()
        {
            SendPanelsToDrawer();

            gameField = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            
            line = 0;
            whoIsWinner = 0;

            isNowAIMove = false;
            whoFirstMoved = 0;
            doesUserMoveFirst = false;

            xOfPreviousMove = -1;
            yOfPreviousMove = -1;
            xOfCurrentMove = 0;
            yOfCurrentMove = 0;

            wasGameInitialized = false;
            isGameOver = false;

            
            this.ai = new ArtificialIntelligence();
            Drawer.CleanAllMoves();

            // User moves first by default.
            isNowAIMove = false;
            whoFirstMoved = WhoseMove.User;
            doesUserMoveFirst = true;
        }

        public static void RenderGameOverMessage()
        {
            if (GameController.isGameOver == true)
                return;

            string gameOverMessage = "";
            if (GameController.whoIsWinner == 0)
            {
                gameOverMessage = "Ничья.";
            }
            else if (GameController.whoIsWinner == WhoseVictory.AI)
            {
                gameOverMessage = "Искусственный интелект.";
            }
            else
            {
                gameOverMessage = "Ты о.О wtf&!?";
            }
            GameController.isGameOver = true;
            MessageBox.Show("Победитель: " + gameOverMessage);
        }

        public void RealizeGameAlgorithm()
        {
            // Проверка на завершение игры.
            if (isGameOver == true)
            {
                return;
            }
            GameStatusController.CheckIfAIWins();
            GameStatusController.CheckIfGameFieldIsFull();

            if (whoIsWinner == WhoseVictory.Draw)
            {
                ai.DefendFromUser(); 

                if (isNowAIMove == true)
                {
                    if (whoFirstMoved == WhoseMove.AI) // Если первым ходил компьютер, то 1, если пользователь - то 2.
                    {
                        if (xOfPreviousMove < 0)
                        {
                            ai.MoveToCenter();
                        }
                        else
                        {
                            ai.MoveToFarthestAngle();
                        }//так называется метод, который выполняет ход в самый отдаленный угол от предыдущего хода пользователя
                    }
                    else //компьютер ходит вторым
                    {
                        if (xOfPreviousMove == 1 &&
                            yOfPreviousMove == 1) //пользователь первым ходом сходил в центр
                        {
                            ai.MoveToFreeAngle(); 
                        }
                        else //пользователь первым ходом не сходил в центр
                        {
                            if (doesUserMoveFirst)  //данная булевая переменная хранит true, если пользователь собирается сделать первый ход в этой партии
                            {
                                ai.MoveToCenter(); 
                                doesUserMoveFirst = false;
                            }
                            else
                            {
                                ai.MoveToFarthestAngle();
                            }
                        }
                    }
                }
                GameStatusController.CheckIfGameFieldIsFull();
            }
            else
            {
                RenderGameOverMessage();
            }
        }

        #region [[[ Winform events ]]]
        private void panel1_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[0, 0] > 0)
                return;
            Player.MakeUserMove(0, 0);
            panel1.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel2_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[0, 1] > 0)
                return;
            Player.MakeUserMove(0, 1);
            panel2.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel3_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[0, 2] > 0)
                return;
            Player.MakeUserMove(0, 2);
            panel3.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel4_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[1, 0] > 0)
                return;
            Player.MakeUserMove(1, 0);
            panel4.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel5_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[1, 1] > 0)
                return;
            Player.MakeUserMove(1, 1);
            panel5.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel6_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[1, 2] > 0)
                return;
            Player.MakeUserMove(1, 2);
            panel6.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel7_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[2, 0] > 0)
                return;
            Player.MakeUserMove(2, 0);
            panel7.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel8_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[2, 1] > 0)
                return;
            Player.MakeUserMove(2, 1);
            panel8.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }

        private void panel9_Click(object sender, EventArgs e)　//　書く
        {
            if (!GameController.wasGameInitialized)
                return;
            if (GameController.isNowAIMove)
                return;
            if (GameController.gameField[2, 2] > 0)
                return;
            Player.MakeUserMove(2, 2);
            panel9.BackColor = System.Drawing.Color.Navy;

            RealizeGameAlgorithm();
        }
        #endregion [[[ Winform events ]]]
    }
}
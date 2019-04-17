using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNoliki
{
    /// <summary>
    /// This class is responsible for drawing part of program.
    /// It draws the game field and all moves during the game.
    /// </summary>
    static class Drawer
    {
        static Panel panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9;
        public static void DefinePanels(GameController fr)
        {
            // Передача контролов элементов Панелей классу действий
            Drawer.panel1 = fr.panel1;
            Drawer.panel2 = fr.panel2;
            Drawer.panel3 = fr.panel3;
            Drawer.panel4 = fr.panel4;
            Drawer.panel5 = fr.panel5;
            Drawer.panel6 = fr.panel6;
            Drawer.panel7 = fr.panel7;
            Drawer.panel8 = fr.panel8;
            Drawer.panel9 = fr.panel9;
        }

        /// <param name="x">Coordinate by "y" axis (0,1,2)
        /// "Y" axis heads down, in othes words the axis is in the negative part,
        /// but to make it comfortable, we take it by module.</param>
        /// <param name="y">Coordinate by "x" axis (0,1,2).</param>
        public static void PaintAIMove(int x, int y)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            switch (x)
            {
                case 0:
                    switch (y)
                    {
                        case 0:
                            panel1.BackColor = System.Drawing.Color.Red;
                            break;
                        case 1:
                            panel2.BackColor = System.Drawing.Color.Red;
                            break;
                        case 2:
                            panel3.BackColor = System.Drawing.Color.Red;
                            break;
                    }
                    break;
                case 1:
                    switch (y)
                    {
                        case 0:
                            panel4.BackColor = System.Drawing.Color.Red;
                            break;
                        case 1:
                            panel5.BackColor = System.Drawing.Color.Red;
                            break;
                        case 2:
                            panel6.BackColor = System.Drawing.Color.Red;
                            break;
                    }
                    break;
                case 2:
                    switch (y)
                    {
                        case 0:
                            panel7.BackColor = System.Drawing.Color.Red;
                            break;
                        case 1:
                            panel8.BackColor = System.Drawing.Color.Red;
                            break;
                        case 2:
                            panel9.BackColor = System.Drawing.Color.Red;
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Clear game field.
        /// </summary>
        public static void CleanAllMoves()
        {
            panel1.BackColor = System.Drawing.Color.Silver;
            panel2.BackColor = System.Drawing.Color.Silver;
            panel3.BackColor = System.Drawing.Color.Silver;
            panel4.BackColor = System.Drawing.Color.Silver;
            panel5.BackColor = System.Drawing.Color.Silver;
            panel6.BackColor = System.Drawing.Color.Silver;
            panel7.BackColor = System.Drawing.Color.Silver;
            panel8.BackColor = System.Drawing.Color.Silver;
            panel9.BackColor = System.Drawing.Color.Silver;
        }
    }
}

//1. Добавить счет.
//2. (п.з.) Рассмотреть существующие алгоритмы.
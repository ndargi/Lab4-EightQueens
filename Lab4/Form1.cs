﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int queens = 0;
        private Bitmap BlackQ;
        private Bitmap WhiteQ;
        private int[,] Game_Board = new int[8, 8];
        public Form1()
        {
            InitializeComponent();
            BlackQ = new Bitmap(@"..\..\BlackQ.png");
            WhiteQ = new Bitmap(@"..\..\WhiteQ.png");
            for (int i = 0;i<8;i++)
            {
                for (int j = 0; j<8;j++)
                {
                    Game_Board[i, j] = 0;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen BlackPen = new Pen(Brushes.Black);
            Graphics g = e.Graphics;
            
            for (int i = 0; i<8;i++)
            {
                for (int j = 0; j<8;j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            g.FillRectangle(Brushes.White, 100 + 50 * j, 100 + 50 * i, 50, 50);//Fill Square Border
                            if (Game_Board[j, i] == 2)
                            {
                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                }
                            }
                            if (Game_Board[j, i] == 1)
                            {
                                
                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                }
                                g.DrawImage(BlackQ, 100 + 50 * j + 2, 100 + 50 * i + 2, 45, 45);//How to draw Q in Space
                            }
                           
                        }
                        else
                        {
                            g.FillRectangle(Brushes.Black, 100 + 50 * j, 100 + 50 * i, 50, 50);
                            if (Game_Board[j, i] == 2)
                            {
                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                }
                            }
                            if (Game_Board[j, i] == 1)
                            {
                                
                                g.DrawImage(WhiteQ, 100 + 50 * j + 2, 100 + 50 * i + 2, 45, 45);//How to draw Q in Space

                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                    g.DrawImage(BlackQ, 100 + 50 * j + 2, 100 + 50 * i + 2, 45, 45);//How to draw Q in Space

                                }
                            }
                            
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            
                            g.FillRectangle(Brushes.Black, 100 + 50 * j, 100 + 50 * i, 50, 50);
                            if (Game_Board[j, i] == 2)
                            {
                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                }
                            }
                            if (Game_Board[j, i] == 1)
                            {
                                
                                g.DrawImage(WhiteQ, 100 + 50 * j + 2, 100 + 50 * i + 2, 45, 45);//How to draw Q in Space

                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                    g.DrawImage(BlackQ, 100 + 50 * j + 2, 100 + 50 * i + 2, 45, 45);//How to draw Q in Space

                                }
                            }
                            
                        }
                        else
                        {
                            g.FillRectangle(Brushes.White, 100 + 50 * j, 100 + 50 * i, 50, 50);
                            if (Game_Board[j, i] == 2)
                            {
                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                }
                            }
                            if (Game_Board[j, i] == 1)
                            {
                                
                                if (Hints.Checked)
                                {
                                    g.FillRectangle(Brushes.Red, 100 + 50 * j, 100 + 50 * i, 50, 50);
                                }
                                g.DrawImage(BlackQ, 100 + 50 * j + 2, 100 + 50 * i + 2, 45, 45);//How to draw Q in Space
                            }
                           
                        }
                    }
                    g.DrawRectangle(BlackPen, 100 + 50 * j, 100 + 50 * i, 50, 50);//Create Square Border
                }
            }
            string queenstring = "You have " + queens + " queens on the board.";
            
            g.DrawString(queenstring, Font, Brushes.Black, 280, 39);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point P = new Point(e.X - 100, e.Y - 100);
            int squarex = P.X / 50;//X Block Location of Click
            int squarey = P.Y / 50;//Y Block Location of Click
            if (e.Button == MouseButtons.Left)
            {
                if ((squarex >= 0) && (squarex <= 7) && (squarey >= 0) && (squarey <= 7))//Statement to see if a square was clicked
                {
                    if (Game_Board[squarex, squarey] == 0)//Checks if Queen can be placed
                    {
                        Game_Board[squarex, squarey] = 1;//Adds the Queen to the board
                        Game_Board = Location_Checker(Game_Board);//Repopulates the board appropriately
                        if (queens == 8)
                        {
                            MessageBox.Show("You did it!");
                        }
                    }
                    else
                    {
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Game_Board[squarex, squarey] = 0;
                Game_Board = Location_Checker(Game_Board);//Repopulates the board appropriately
            }


            Invalidate();
        }
        private int[,] Location_Checker(int[,] Board)//Function to check if Location is allowed
        {
            queens = 0;
            for (int i = 0; i < 8; i++)//Initialize all without a queen to zero and then check them
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game_Board[i, j] == 2)
                    {
                        Game_Board[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Board[i, j] == 0)//Checks all areas labeled as safe to see if this is true
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (Game_Board[i,k] == 1)
                            {
                                if(k != j)
                                {
                                    Game_Board[i, j] = 2;                              
                                }
                            }
                            if (Game_Board[k,j] == 1)
                            {
                                if(k!=i)
                                {
                                    Game_Board[i, j] = 2;
                                }
                            }                                                 
                        }
                        int l = i - 1;
                        int m = j - 1;
                        while (l != -1 && m != -1)// check left and up diagonals
                        {
                            if (Game_Board[l,m] == 1)
                            {
                                Game_Board[i, j] = 2;
                            }
                            l--;
                            m--;
                        }
                         l = i + 1;
                         m = j + 1;
                        while (l != 8 && m != 8)//Check right and down diagonals
                        {
                            if (Game_Board[l, m] == 1)
                            {
                                Game_Board[i, j] = 2;
                            }
                            l++;
                            m++;
                        }
                        l = i + 1;
                        m = j - 1;
                        while (l != 8 && m != -1)// Check right and up diagonals
                        {
                            if (Game_Board[l, m] == 1)
                            {
                                Game_Board[i, j] = 2;
                            }
                            l++;
                            m--;
                        }
                        l = i - 1;
                        m = j + 1;
                        while (l != -1 && m != 8)//Check left and down diagonals
                        {
                            if (Game_Board[l, m] == 1)
                            {
                                Game_Board[i, j] = 2;
                            }
                            l--;
                            m++;
                        }
                    }


                   
                }
            }
            for (int i = 0; i < 8; i++)//Initialize all without a queen to zero and then check them
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game_Board[i, j] == 1)
                    {
                        queens++;
                    }
                }
            }
            return Board;//Returns updated array
        }

        private void Clear_Click(object sender, EventArgs e)//Clears all Queens from the board
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Game_Board[i, j] = 0;
                }
            }
            Invalidate();
        }

        private void Hints_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//create by He Yuanhua
//create time: 20170210
//the programe is call Simon Game, it is a 80s' memory game
namespace Simon_game
{
    public partial class Gamescreen : UserControl
    {
        int guess;
        //creates a random number between 0 and 4 



        public Gamescreen()
        {
            InitializeComponent();
        }


        private void Gamescreen_Load(object sender, EventArgs e)
        {
            this.Refresh();

            //cleaer the pattern list
            Form1.pattern.Clear();

            Thread.Sleep(1000);

            InitComputerTurn();
        }

        public void InitComputerTurn()
        {
            Random randNum = new Random();
            int rand = randNum.Next(0, 4);
            Form1.pattern.Add(rand);

            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DeepSkyBlue;
                    Thread.Sleep(200);
                }
                else
                {                   
                    Refresh();
                    Thread.Sleep(1000);
                }

            }
        }

        private void greenButton_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DeepSkyBlue;
                    Thread.Sleep(200);
                }
                else
                {
                    Refresh();
                    Thread.Sleep(1000);
                }

            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DeepSkyBlue;
                    Thread.Sleep(200);
                }
                else
                {
                    Refresh();
                    Thread.Sleep(1000);
                }

            }
        }

        private void yellowButton_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DeepSkyBlue;
                    Thread.Sleep(200);
                }
                else
                {
                    Refresh();
                    Thread.Sleep(1000);
                }

            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DeepSkyBlue;
                    Thread.Sleep(200);
                }
                else
                {
                    Refresh();
                    Thread.Sleep(1000);
                }

            }
        }
    }
}


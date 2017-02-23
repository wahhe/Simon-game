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
using System.Media;
//create by He Yuanhua
//create time: 20170210
//the programe is call Simon Game, it is a 80s' memory game
namespace Simon_game
{
    public partial class Gamescreen : UserControl
    {
        int guess = 0;
        //creates a random number between 0 and 4 
        Random randNum = new Random();
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.playsound);


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
            int rand = randNum.Next(0, 4);
            Form1.pattern.Add(rand);


            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    player1.Play();
                    greenButton.BackColor = Color.LimeGreen;
                    Refresh();
                    Thread.Sleep(400);
                    player1.Stop();
                    greenButton.BackColor = Color.DarkGreen;
                    Refresh();
                    Thread.Sleep(400);
                }
                else if (Form1.pattern[i] == 1)
                {
                    player1.Play();
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(400);
                    player1.Stop();
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    Thread.Sleep(400);
                }
                else if (Form1.pattern[i] == 2)
                {
                    player1.Play();
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(400);
                    player1.Stop();
                    yellowButton.BackColor = Color.Gold;
                    Refresh();
                    Thread.Sleep(400);
                }
                else if (Form1.pattern[i] == 3)
                {
                    player1.Play();
                    blueButton.BackColor = Color.DeepSkyBlue;
                    Refresh();
                    Thread.Sleep(400);
                    player1.Stop();
                    blueButton.BackColor = Color.SteelBlue;
                    Refresh();
                    Thread.Sleep(400);
                }
            }
            //set guess back to 0
            guess = 0;
        }

        private void greenButton_MouseClick(object sender, MouseEventArgs e)
        {

            // if Form1.pattern[guess] == 0
            if (Form1.pattern[guess] == 0)
            {
                //show bright green
                greenButton.BackColor = Color.LimeGreen;
                Refresh();
                Thread.Sleep(400);

                //go back to regular colour
                greenButton.BackColor = Color.DarkGreen;
                Refresh();
                Thread.Sleep(400);

                //guess++;
                guess++;

                // if guess == Form1.pattern.Count()
                if (guess == Form1.pattern.Count())
                {
                    //ComputerTurn
                    InitComputerTurn();
                }
                //gameover

            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            // if Form1.pattern[guess] == 0
            if (Form1.pattern[guess] == 1)
            {
                //show bright red
                redButton.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(400);

                //go back to regular colour
                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(400);

                //guess++;
                guess++;

                // if guess == Form1.pattern.Count()
                if (guess == Form1.pattern.Count())
                {
                    //ComputerTurn
                    InitComputerTurn();
                }
                //gameover

            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }
        }

       // private void yellowButton_MouseClick(object sender, MouseEventArgs e)
                  
       // private void blueButton_Click(object sender, EventArgs e)
        

        private void yellowButton_Click(object sender, EventArgs e)
        {
            // if Form1.pattern[guess] == 0
            if (Form1.pattern[guess] == 2)
            {
                //show bright yellow
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(500);

                //go back to regular colour
                yellowButton.BackColor = Color.Gold;
                Refresh();
                Thread.Sleep(500);

                //guess++;
                guess++;

                // if guess == Form1.pattern.Count()
                if (guess == Form1.pattern.Count())
                {
                    //ComputerTurn
                    InitComputerTurn();
                }
                //gameover

            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            // if Form1.pattern[guess] == 0
            if (Form1.pattern[guess] == 3)
            {
                //show bright blue
                blueButton.BackColor = Color.DeepSkyBlue;
                Refresh();
                Thread.Sleep(400);

                //go back to regular colour
                blueButton.BackColor = Color.SteelBlue;
                Refresh();
                Thread.Sleep(400);

                //guess++;
                guess++;

                // if guess == Form1.pattern.Count()
                if (guess == Form1.pattern.Count())
                {
                    //ComputerTurn
                    InitComputerTurn();
                }
                //gameover

            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }
        }
    }
}


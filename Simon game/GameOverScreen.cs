using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Simon_game
{
    public partial class GameOverScreen : UserControl
    {
       
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.gameover);
        public GameOverScreen()
        {
            InitializeComponent();
            player2.Play();      
            // get the length of the patten array and show it.
            plLabel.Text = " you patten length was: " + Form1.pattern.Count;
        }

        public static implicit operator GameOverScreen(Gamescreen v)
        {
            throw new NotImplementedException();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Mainscreen ms = new Mainscreen();
            f.Controls.Add(ms);
        }
    }
}

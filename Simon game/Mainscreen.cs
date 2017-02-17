using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_game
{
    public partial class Mainscreen : UserControl
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Gamescreen gs = new Gamescreen();
            f.Controls.Add(gs);
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

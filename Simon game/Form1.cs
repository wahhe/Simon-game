using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Simon_game
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();
        
        
        

        



        public Form1()
        {
            InitializeComponent();
        }

        // private void playButton_Click(object sender, EventArgs e)
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //launch the Main Screen
            Mainscreen ms = new Mainscreen();
            this.Controls.Add(ms);
        }
    }
}

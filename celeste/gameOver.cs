using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celeste
{
    public partial class gameOver : UserControl
    {

        public gameOver()
        {
            InitializeComponent();
        }

        private void gameOver_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new menuScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

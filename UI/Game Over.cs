using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Game_Over : Form
    {
        public Game_Over()
        {
            InitializeComponent();
        }

        private void Game_Over_Load(object sender, EventArgs e)
        {

        }

        private void Game_Over_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonViewHighScores_Click(object sender, EventArgs e)
        {
            HighScore highscores = new HighScore();
            highscores.ShowDialog();
        }

        
    }
}

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
    public partial class WumpusForm : Form
    {
        int caveChosen = 0;
        public WumpusForm()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            caveChosen = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caveChosen = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caveChosen = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            caveChosen = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            caveChosen = 5;
        }


        public int chooseCave()
        {
            return caveChosen;
        }
    }
}


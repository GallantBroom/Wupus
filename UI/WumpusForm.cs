﻿using System;
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
    public partial class WumpusStart : Form
    {

        public WumpusStart()
        {
            InitializeComponent();
        }


        private void pictureBoxStartButton_Click(object sender, EventArgs e)
        {
            WumpusStart wem = new WumpusStart();
            wem.Close();

            Select_Cave SelectCaveDLG = new Select_Cave();

            SelectCaveDLG.Show();








        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
    public partial class Select_Cave : Form
    {
        public Select_Cave()
        {
            InitializeComponent();
        }

        int cave = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            cave = 1;

            Main MainDLG = new Main();

            //move the global variable info to the summary form
            MainDLG.cave = cave;


            //display
            MainDLG.ShowDialog();
           
        }

        private void buttonCave2_Click(object sender, EventArgs e)
        {
            cave = 2;

            Main MainDLG = new Main();

            //move the global variable info to the summary form
            MainDLG.cave = cave;

            //display
            MainDLG.ShowDialog();
            
        }

        private void buttonCave3_Click(object sender, EventArgs e)
        {
            cave = 3;

            Main MainDLG = new Main();

            //move the global variable info to the summary form
            MainDLG.cave = cave;

            //display
            MainDLG.ShowDialog();
            
        }

        private void buttonCave4_Click(object sender, EventArgs e)
        {
            cave = 4;

            Main MainDLG = new Main();

            //move the global variable info to the summary form
            MainDLG.cave = cave;

            //display
            MainDLG.ShowDialog();
            

        }

        private void buttonCave5_Click(object sender, EventArgs e)
        {
            cave = 5;

            Main MainDLG = new Main();

            //move the global variable info to the summary form
            MainDLG.cave = cave;

            //display
            MainDLG.ShowDialog();
            

        }
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {


            Main MainDLG = new Main();

            //move the global variable info to the summary form
            

            //display
            MainDLG.ShowDialog();
        }
    }
}

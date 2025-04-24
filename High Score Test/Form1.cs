using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    
    public partial class Form1 : Form
    {
        private Cave _Cave;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            _Cave = new Cave();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

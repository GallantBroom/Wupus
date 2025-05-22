using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GameLocation
{
    public class GameLocation
    { }

}


namespace GameLocationTest1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpawn_Click(object sender, EventArgs e)
        {
            GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
        }
        
    }
}

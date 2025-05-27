using Cave;
using CaveTest;
using GameControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        GameControl.GameControl gamecontrol = new GameControl.GameControl();


        private void warnUser()
        {
            int[] connectingRooms = GameControl.GameControl.getConnectingRooms(2, 12);

            int[] hazards = gamecontrol.giveUIHazards();

           



        }
        



        private void connectingRooms()
        {
            buttonEast.Enabled = false;
            buttonNorthEast.Enabled = false;
            buttonSouthEast.Enabled = false;
            buttonNorthWest.Enabled = false;
            buttonWest.Enabled = false;
            buttonSouthWest.Enabled = false;

            int cave = int.Parse(textBoxCaveNumber.Text);
            int room = int.Parse(textBoxRoomNumber.Text);
            int[] connectingRooms = GameControl.GameControl.getConnectingRooms(cave, room);

            int[] freePathways = UI.findCorrectDirection(connectingRooms, room);




            for (int i = 0; i < freePathways.Length; i++)
            {


                if (freePathways[i] == 1)
                {
                    buttonNorthWest.Enabled = true;

                }

                else if (freePathways[i] == 2)
                {

                    buttonNorthEast.Enabled = true;

                }
                else if (freePathways[i] == 6)
                {

                    buttonWest.Enabled = true;
                }

                else if ((freePathways[i] == 3))
                {


                    buttonEast.Enabled = true;
                }

                else if (freePathways[i] == 4)
                {
                    buttonSouthEast.Enabled = true;

                }
                else if (((freePathways[i] == 5)))
                {

                    buttonSouthWest.Enabled = true;
                }




            }
        }





        private void Main_Load(object sender, EventArgs e)
        {

            //connectingRooms();








        }

        private void buttonNorthEast_Click(object sender, EventArgs e)
        {

            //currentroom -= 5;
            connectingRooms();
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {

            //if (currentroom == 6 || currentroom == 12 || currentroom == 18 || currentroom == 24 || currentroom == 30) { currentroom += 5; }

            //else { currentroom += 1; }

            connectingRooms();

        }

        private void buttonSouthEast_Click(object sender, EventArgs e)
        {
            //currentroom += 6;
            connectingRooms();
        }

        private void buttonSouthWest_Click(object sender, EventArgs e)
        {
            //currentroom += 5;
            connectingRooms();
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            ///if (currentroom == 1 || currentroom == 7 || currentroom == 13 || currentroom == 19 || currentroom == 25)
            //{
            //currentroom += 5;

            //}
            //else { currentroom -= 1; }

            connectingRooms();
        }

        private void buttonNorthWest_Click(object sender, EventArgs e)
        {
            //currentroom -= 6;
            connectingRooms();
        }

        private void buttonCalculateRoomDirections_Click(object sender, EventArgs e)
        {
            connectingRooms();
        }

        private void pictureBoxCoin_Click(object sender, EventArgs e)
        {

        }

        private void labelHints_Click(object sender, EventArgs e)
        {

        }
    }
}

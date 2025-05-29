using Cave;
using CaveTest;
using GameControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        Cave.Cave Cave = new Cave.Cave();
        int cave = 1;
        int room = 1;


        private void warnUser()
        {
            int[] near = [1,1,1];

            labelHints.Text = "";


            if (near[0] == 1)
            {
                labelHints.Text += "There's a Skeleton in this room, there must be a trap nearby.";
            }
            if (near[1] == 1)
            {
                labelHints.Text += '\n' + "You smell a Wumpus nearby.";
            }
            if (near[2] == 1)
            {
                labelHints.Text += '\n' + "You feel a Breeze.";
            }





        }
        



        private void connectingRooms()
        {
            buttonEast.Enabled = false;
            buttonNorthEast.Enabled = false;
            buttonSouthEast.Enabled = false;
            buttonNorthWest.Enabled = false;
            buttonWest.Enabled = false;
            buttonSouthWest.Enabled = false;

            
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

            connectingRooms();
            warnUser();








        }

        private void buttonNorthEast_Click(object sender, EventArgs e)
        {

            room -= 5;
            connectingRooms();
            warnUser();
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {

            if (room == 6 || room == 12 || room == 18 || room == 24 || room == 30) {room += 5; }

            else { room += 1; }

            connectingRooms();
            warnUser();

        }

        private void buttonSouthEast_Click(object sender, EventArgs e)
        {
            room += 6;
            connectingRooms();
            warnUser();
        }

        private void buttonSouthWest_Click(object sender, EventArgs e)
        {
            room += 5;
            connectingRooms();
            warnUser();
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            if (room == 1 || room == 7 || room == 13 || room == 19 || room == 25)
            {
            room += 5;

            }
            else { room -= 1; }

            connectingRooms();
            warnUser();
        }

        private void buttonNorthWest_Click(object sender, EventArgs e)
        {
            room -= 6;
            connectingRooms();
            warnUser();
        }

        private void buttonCalculateRoomDirections_Click(object sender, EventArgs e)
        {
            connectingRooms();
            warnUser();
            textBoxCaveNumber.Text = room.ToString();
        }

        private void pictureBoxCoin_Click(object sender, EventArgs e)
        {

        }

        private void labelHints_Click(object sender, EventArgs e)
        {
            

        }
    }
}

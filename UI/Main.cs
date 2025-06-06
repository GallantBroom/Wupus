﻿using Cave;
using CaveTest;
using GameControl;
using GameLocation;
using High_Score;
using Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            pictureBox1.Image = Properties.Resources.EmptyCave;
            labelAlerts.Text = "";
        }
        public int cave { get; set; }
        public int[] TrapLocations { get; set; }
        public List<PlayerScore> highScores;



        GameControl.GameControl gamecontrol = new GameControl.GameControl();
        GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
        
        int[] connectedRooms;


        int room = 1;
        int Where = 0;
        int turns = 0;
        bool gameOverFlag = true;

        private void warnUser()
        {

            //label1.Text = connectedRooms[0].ToString();
            //label2.Text = connectedRooms[1].ToString();
            //label3.Text = connectedRooms[2].ToString();
            //labelRoomNumber.Text = room.ToString();
            Select_Cave caveDLG = new Select_Cave();


            int[] near = gamecontrol.giveUIHazards(connectedRooms, TrapLocations);

            labelHints.Text = "";
            labelHint2.Text = "";
            labelHint3.Text = "";

            if (near[0] == 1)
            {
                labelHints.Text += "There's a Skeleton in this room, there must be a trap nearby.";
                //pictureBox1.Image = Properties.Resources.SkelitonCave;
            }
            if (near[1] == 1)
            {
                labelHint2.Text += "You smell a Wumpus nearby.";

            }
            if (near[2] == 1)
            {
                labelHint3.Text += "You feel a Breeze.";

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


            connectedRooms = GameControl.GameControl.getConnectingRooms(cave, room);

            int[] freePathways = UI.findCorrectDirection(connectedRooms, room);




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
            
            if (radioButton1.Checked)
            {
                int[] Wumpus = gamecontrol.giveUIHazards(connectedRooms, TrapLocations);
                if (Wumpus[1] == 1)
                {

                }
            }
            else
            {
                if (room == 5 || room == 1 || room == 2 || room == 3 || room == 4 || room == 6) { room += 24; }
                else if (room == 30 || room == 24 || room == 18 || room == 12) { room -= 11; }
                else { room -= 5; }
                connectingRooms();
                warnUser();
                Land();
            }
            turns++;


        }

        private void buttonEast_Click(object sender, EventArgs e)
        {

            if (room == 6 || room == 12 || room == 18 || room == 24 || room == 30) { room -= 5; }

            else { room += 1; }

            connectingRooms();
            warnUser();
            Land();
            turns++;

        }

        private void buttonSouthEast_Click(object sender, EventArgs e)
        {
            if (room == 30) { room -= 29; }
            else if (room == 26 || room == 25 || room == 27 || room == 28 || room == 29) { room -= 23; }

            else { room += 6; }
            // pictureBox1.Image = Properties.Resources.EmptyCave;
            connectingRooms();
            warnUser();
            Land();
            turns++;

        }

        private void buttonSouthWest_Click(object sender, EventArgs e)
        {
            if (room == 26 || room == 25 || room == 27 || room == 28 || room == 29 || room == 30) { room -= 24; }
            else if (room == 1 || room == 7 || room == 13 || room == 19) { room += 11; }
            else { room += 5; }
            //pictureBox1.Image = Properties.Resources.EmptyCave;
            connectingRooms();
            warnUser();
            Land();
            turns++;

        }

        private void buttonWest_Click(object sender, EventArgs e)
        {

            if (room == 1 || room == 7 || room == 13 || room == 19 || room == 25)
            {
                room += 5;

            }
            else { room -= 1; }
            // pictureBox1.Image = Properties.Resources.EmptyCave;
            connectingRooms();
            warnUser();
            Land();
            turns++;

        }

        private void buttonNorthWest_Click(object sender, EventArgs e)
        {
            if (room == 1) { room += 29; }
            else if (room == 3 || room == 2 || room == 4 || room == 5 || room == 6) { room += 23; }

            else { room -= 6; }
            //  pictureBox1.Image = Properties.Resources.EmptyCave;
            connectingRooms();
            warnUser();
            Land();
            turns++;

        }

        private void buttonCalculateRoomDirections_Click(object sender, EventArgs e)
        {

            //textBoxCaveNumber.Text = room.ToString();
        }

        private void pictureBoxCoin_Click(object sender, EventArgs e)
        {

        }

        private void labelHints_Click(object sender, EventArgs e)
        {


        }

        private void buttonShop_Click(object sender, EventArgs e)
        {

        }
        private void Land()
        {
            labelAlerts.Text = "";
            Where = gameLocation.PlayerMove(room, TrapLocations);
            if (Where == 1)
            {
                pictureBox1.Image = Properties.Resources.Wumpus;
               
                gameOverFlag = false;
                labelAlerts.Text = "You have been eaten by the Wumpus! Game Over!";
                Game_Over gameOverForm = new Game_Over();

                gameOverForm.ShowDialog();
            }
            else if (Where == 2)
            {
                pictureBox1.Image = Properties.Resources.Trap;
                int newLoc = gameLocation.Trapped(room);
                room = newLoc;

                labelAlerts.Text = "You have been trapped! Your new position is: " + room;
            }
            else if (Where == 3)
            {
               
                pictureBox1.Image = Properties.Resources.PitCave;
                gamecontrol.FellInPit();
                labelAlerts.Text = "You have fallen into a pit!, Game Over!";
                Game_Over gameOverForm = new Game_Over();

                gameOverForm.ShowDialog();

            }
            else
            {
                pictureBox1.Image = Properties.Resources.EmptyCave;
            }
            
            labelTurns.Text = "Turns: " + turns.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gamecontrol.displayHighScores(true,3,"Hello!");
            gameOverFlag = false;
        }

        private void labelTurns_Click(object sender, EventArgs e)
        {

        }
    }
}

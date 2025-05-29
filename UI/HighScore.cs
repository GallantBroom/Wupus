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
    public partial class HighScore : Form
    {

        High_Score.High_Score[] topPlayers = new High_Score.High_Score[9];
        High_Score.High_Score[] topScores = new High_Score.High_Score[9];
        public HighScore()
        {
            InitializeComponent();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {

            //Get the top players from high score
            //topPlayers = High_Score.High_Score.getTopPayers();

            //Get the top scores from high score
            //topScores = High_Score.High_Score.getTopScores();




            //adding the usernames to the form 
            labelName1.Text = topPlayers[0].ToString();
            labelName2.Text = topPlayers[1].ToString();
            labelName3.Text = topPlayers[2].ToString();
            labelName4.Text = topPlayers[3].ToString();
            labelName5.Text = topPlayers[4].ToString();
            labelName6.Text = topPlayers[5].ToString();
            labelName7.Text = topPlayers[6].ToString();
            labelName8.Text = topPlayers[7].ToString();
            labelName9.Text = topPlayers[8].ToString();
            labelName10.Text = topPlayers[9].ToString();


            //adding top scores to the form

            labelScore1.Text = topScores[0].ToString();
            labelScore2.Text = topScores[1].ToString();
            labelScore3.Text = topScores[2].ToString();
            labelScore4.Text = topScores[3].ToString();
            labelScore5.Text = topScores[4].ToString();
            labelScore6.Text = topScores[5].ToString();
            labelScore7.Text = topScores[6].ToString();
            labelScore8.Text = topScores[7].ToString();
            labelScore9.Text = topScores[8].ToString();
            labelScore10.Text = topScores[9].ToString();



        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}

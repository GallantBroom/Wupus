using High_Score;
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

        List<PlayerScore> highScores;


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
            labelName1.Text = highScores[0].ToString();
            labelName2.Text = highScores[1].ToString();
            labelName3.Text = highScores[2].ToString();
            labelName4.Text = highScores [3].ToString();
            labelName5.Text = highScores [4].ToString();
            labelName6.Text = highScores[5].ToString();
            labelName7.Text = highScores [6].ToString();
            labelName8.Text = highScores[7].ToString();
            labelName9.Text = highScores[8].ToString();
            labelName10.Text = highScores[9].ToString();


            

            



        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}

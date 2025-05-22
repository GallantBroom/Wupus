using High_Score;

namespace High_Score_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hscore = new High_Score.High_Score();
            DisplayScores();
        }

        High_Score.High_Score hscore;

        private void buttonAdd_High_Score_Click(object sender, EventArgs e)
        {
            bool changed = false;

            try
            { 
                string name = textBoxName.Text;
                ulong score = ulong.Parse(textBoxScore.Text);
                int cave = int.Parse(textBoxCave.Text);
                changed = hscore.AddScore(name, score, cave);
            }
            catch (OverflowException)
            {
                MessageBox.Show("High Score must be less than 18,446,744,073,709,551,615");
            }
            catch (FormatException)
            {
                MessageBox.Show("Score and Cave must be long integers");
            }

            if (changed)
            {
                DisplayScores();
            }
        }

        private void DisplayScores()
        {
            listBox1.Items.Clear();
            foreach (PlayerScore score in hscore.Scores)
            {
                listBox1.Items.Add(score);
            }
        }


    }
}

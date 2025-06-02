using Trivia;
namespace TriviaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            questions = TriviaLoader.LoadQuestions();
        }


        List<TriviaQuestion> questions;

        int questionListIndex = 0;
        int answerIndex = -1;

        private void buttonGet_Question_Click(object sender, EventArgs e)
        {
            var question = questions[questionListIndex];
            answerIndex = question.CorrectAnswerIndex;
            textBoxQuestion.Text = question.Question;
            radioButton1.Text = question.Answers[0];
            radioButton2.Text = question.Answers[1];
            radioButton3.Text = question.Answers[2];
            radioButton4.Text = question.Answers[3];
            questionListIndex++;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string question = buttonGet_Question.Text;
            string answer = buttonSubmit.Text;

            
            bool isCorrect = CheckAnswer(answer);


            if (isCorrect)
            {
                buttonSubmit.Text = (int.Parse(buttonSubmit.Text) + 1).ToString();
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect. The correct answer is: " + answer);
            }

          
            
        }

        private bool CheckAnswer(string answer)
        {
            throw new NotImplementedException();
        }
    }
}

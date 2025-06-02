using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class TriviaQuestion
    {
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public TriviaQuestion(string question, string answer1, string answer2, string answer3, int correctAnswerIndex)
        {
            Question = question;
            Answers = new string[] { answer1, answer2, answer3 };
            CorrectAnswerIndex = correctAnswerIndex;
        }
        public TriviaQuestion() { }
        
    }

}

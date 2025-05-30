using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class TriviaLoader
    {
        public TriviaLoader() { }
        const string DATA_FILE = "questions.csv";

        public static List<TriviaQuestion> LoadQuestions()
        {
            List<TriviaQuestion> questions = new List<TriviaQuestion>();
            StreamReader streamReader = new StreamReader(DATA_FILE);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] record = line.Split(',');
                TriviaQuestion question = new TriviaQuestion(record[0], record[1], record[2], record[3], int.Parse(record[4]));
                questions.Add(question);
                line = streamReader.ReadLine();

            }

            return questions;

        }
    }
}

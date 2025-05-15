using Microsoft.VisualBasic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;

namespace High_Score
{
    public class High_Score
    {

        /// <summary>
        /// Making the constructor
        /// </summary>
        public High_Score() { }

        private List<PlayerScore> scores = new List<PlayerScore>();
        public List<PlayerScore> Scores 
        {
            get
            {
                return scores.OrderByDescending(x => x.Score).ToList(); 
            } 
        }

        const string SCORES = "scores.json";
       

        public void AddScore(string name, int score, int caveSystem)
        {
            PlayerScore playerScore = new PlayerScore(name, score, caveSystem);
            if (scores.Count < 10)
            {
                scores.Add(playerScore);
            }
            else
            {
                int lowestScore = score;
                int lowestScoreIndex = -1;
                for (int i = 0; i < scores.Count; i++)
                {
                    if (scores[i].Score < lowestScore)
                    {
                        lowestScore = scores[i].Score;
                        lowestScoreIndex = i;
                    }
                }
                if (lowestScoreIndex != -1)
                {
                    scores.RemoveAt(lowestScoreIndex);
                    scores.Add(playerScore);
                }
            }

        }

        /// <summary>
        /// Calculating the players score
        /// </summary>
        private List<PlayerScore> _scores = new List<PlayerScore>();
        public int CalculateScore(int n, int g, int a, int w)
        {
            int finalScore = 100 - n + g + (5 * a) + w;
            return finalScore;
        }
        
    }
}
 
using Microsoft.VisualBasic;
using System.Linq.Expressions;
using System.Net.Mail;
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
        /// Reading form file 
        /// </summary>
        public High_Score()
        {
            FileInfo file = new FileInfo(SCORES);
            if (file.Exists)
            {
                scores = Utility.ReadFromFile(SCORES);
            }
            else
            {
                scores = new List<PlayerScore>();
            }
        }

        private List<PlayerScore> scores;
        public List<PlayerScore> Scores
        {
            get
            {
                return scores.OrderByDescending(x => x.Score).ToList();
            }
        }

        const string SCORES = "scores.json";

        /// <summary>
        /// Added Score to High Score list and displayed to listbox
        /// </summary>
        /// <param name="name">Player Name</param>
        /// <param name="score">Game Score</param>
        /// <param name="caveSystem"> Cave number used in game</param>
        /// <returns>true if score was in the top 10</returns>
        public bool AddScore(string name, ulong score, int caveSystem)
        {
            PlayerScore playerScore = new PlayerScore(name, score, caveSystem);
            if (scores.Count < 10)
            {
                scores.Add(playerScore);
                Utility.WriteToFile(scores, SCORES);
                return true;
            }
            else
            {
                ulong lowestScore = score;
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
                    Utility.WriteToFile(scores, SCORES);
                    return true;
                }
            }

            return false;

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
 
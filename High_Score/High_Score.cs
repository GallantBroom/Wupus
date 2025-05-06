using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace High_Score
{
    public class High_Score
    {
        public High_Score() { }
        const string SCORES = "scores.json";
        public string Number_of_turns { get; set; }
        public string Number_of_gold_coins_left { get; set; }
        public string Number_of_arrows_left { get; set; }
        public string Wumpus_score { get; set; }
        public High_Score(string n, string g, string a, string w)
        {
            Number_of_turns = n;
            Number_of_gold_coins_left = g;
            Number_of_arrows_left = a;
            Wumpus_score = w;
        }

    }
}
 
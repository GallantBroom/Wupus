using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace High_Score
{
    public class PlayerScore
    {
        public PlayerScore(string name, ulong score, int caveSystem)
        {
            Name = name;
            CaveSystem = caveSystem;
            Score = score;
        }

        public ulong Score {  get; set; }
        public string Name { get; set; }
        public int CaveSystem { get; set; }

        public override string ToString() 
        { 
           return $"{Name}\t {CaveSystem}\t {Score}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerClass
    {
        public int Arrows { get; set; }
        public int Coins { get; set; }
        public int Turns { get; set; }
        public int[] inv { get; set; }

        public PlayerClass()
        {
            Arrows = 3; 
            Coins = 5; 
            Turns = 0;
        }
        public void arrowshot()
        {
            Arrows--;
        }

        public int PlayerMove()
        {
            Turns++;
            Coins++;
            return Turns;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLocation;

namespace Player
{
    
    public class PlayerClass
    {
        
        GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
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
            return Turns;
        }

        public int GetScore(bool killedWumpus)
        {
            if (killedWumpus)
            {
                return ((Arrows * 10) - Turns + Coins) + 1000;
            }
            else
            {
                return (Arrows * 10) - Turns + Coins;
            }
            
        }
        public void AddCoin()
        {
            Coins++;
        }
        public int GetCoins()
        {
            return Coins;
        }
    }
}

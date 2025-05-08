using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace GameLocation
{
    public class GameLocation
    {
       
        
        public GameLocation()
        {
            // Constructor logic here
        }
        public int Playerspawn = 1;
        public int BatSpawn = 0;
        public int WumpusSpawn = 0;
        public int PitSpawn = 0;

        public void spawn()
        {
            Random random = new Random();
            int Batspawn = random.Next(2, 30);
            int Wumpusspawn = random.Next(2, 30);
            int Pitspawn = random.Next(2, 30);
            while (Wumpusspawn == Batspawn || Batspawn == Pitspawn || Wumpusspawn == Pitspawn)
            {
                if (Wumpusspawn == Batspawn)
                {
                    if (Wumpusspawn != 30)
                    {
                        Wumpusspawn = +1;
                    }
                    else
                    {
                        Wumpusspawn = 2;
                    }
                }
                else if (Batspawn == Pitspawn)
                {
                    if (Pitspawn != 30)
                    {
                        Pitspawn = +1;
                    }
                    else
                    {
                        Pitspawn = 2;
                    }
                    
                }
                else if (Wumpusspawn == Pitspawn)
                {
                    if (Wumpusspawn != 30)
                    {
                        Wumpusspawn = +1;
                    }
                    else
                    {
                        Wumpusspawn = 2;
                    }

                }
            }
            BatSpawn = Batspawn;
            WumpusSpawn = Wumpusspawn;
            PitSpawn = Pitspawn;
        }


        public void PlayerMove()
        { 

        }
           
    }
}

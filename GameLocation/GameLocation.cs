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
        public int PlayerLocation { get; set; }
        public int Cave { get; set; }
        public GameLocation()
        {
            // Constructor logic here

        }
        public int PlayerSpawn = 1;
        public int TrapSpawn = 0;
        public int WumpusSpawn = 0;
        public int PitSpawn = 0;

        public void Spawn()
        {
            Random random = new Random();
            int Trapspawn = random.Next(2, 30);
            int Wumpusspawn = random.Next(2, 30);
            int Pitspawn = random.Next(2, 30);
            while (Wumpusspawn == Trapspawn || Trapspawn == Pitspawn || Wumpusspawn == Pitspawn)
            {
                if (Wumpusspawn == Trapspawn)
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
                else if (Trapspawn == Pitspawn)
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
            TrapSpawn = Trapspawn;
            WumpusSpawn = Wumpusspawn;
            PitSpawn = Pitspawn;
        }
        public enum Hazards
        {
            Nothing,
            Wumpus,
            Trap,
            Pit
        }

        public Hazards PlayerMove(int cave)
        {
            //I need more info
            //I need which cave the player is moving to
            //What do I need to do?
            //I need to check if the player is hitting any hazards
            //-Wumpus- Return "Landed on Wumpus"
            //-Trap- Randomly move the player, and the trap, Return "Landed on Trap", Guarantee that the player or trap wont land on another hazard
            //-Pit- Return "Landed on Pit"
            //-Nothing- 

            PlayerLocation = cave;

            if (PlayerLocation == WumpusSpawn)
            {
                return Hazards.Wumpus;
            }
            else if (PlayerLocation == TrapSpawn)
            {
                Trapped();
                return Hazards.Trap;
            }
            else if (PlayerLocation == PitSpawn)
            {
                return Hazards.Pit;
            }
            return Hazards.Nothing;
        }

        public int GetCave(int adg1, int adg2, int adg3)
        {
            int Near = 0;
            if (adg1 == TrapSpawn || adg2 == TrapSpawn || adg3 == TrapSpawn)
            {
                Near = 1;
                return Near;
            }
            if (adg1 == WumpusSpawn || adg2 == WumpusSpawn || adg3 == WumpusSpawn)
            {
                Near = 2;
                return Near;
            }
            if (adg1 == PitSpawn || adg2 == PitSpawn || adg3 == PitSpawn)
            {
                Near = 3;
                return Near;
            }
            else
            {
                return 0;
            }
        }


        private void Trapped()
        {
            Random random = new Random();
            Random rand = new Random();
            int NewPlayerLocation = rand.Next(1, 30);
            int NewTrapspawn = random.Next(2, 30);
            while (NewTrapspawn == NewPlayerLocation || NewPlayerLocation == WumpusSpawn || NewPlayerLocation == PitSpawn)
            {
                if (NewTrapspawn != 30)
                {
                    NewTrapspawn = +1;
                }
                else
                {
                    NewTrapspawn = 1;
                }
                
            }
            while (NewPlayerLocation == TrapSpawn || NewPlayerLocation == WumpusSpawn || NewPlayerLocation == PitSpawn)
            {
                if (NewPlayerLocation != 30)
                {
                    NewPlayerLocation = +1;
                }
                else
                {
                    NewPlayerLocation = 1;
                }
            }
            
            PlayerLocation = NewPlayerLocation;
            TrapSpawn = NewTrapspawn;
        }







    }
}

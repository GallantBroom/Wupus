using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.IsolatedStorage;
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
        public int TrapSpawn2 = 0;
        public int TrapSpawn3 = 0;
        public int PitSpawn2 = 0;
        public int PitSpawn3 = 0;
        public int[] Values = new int[7];
        public int[] Coins = new int[10]; // Array to hold coin locations
        public int[] Spawn()
        {

            Random random = new Random();
            HashSet<int> usedNumbers = new HashSet<int>();

            while (usedNumbers.Count < 7)
            {
                usedNumbers.Add(random.Next(2, 30)); // 30 is exclusive, 2 is inclusive
            }

            int[] values = new int[7];
            usedNumbers.CopyTo(values);

            // Optional: assign to meaningful variables
            TrapSpawn = values[0];
            WumpusSpawn = values[1];
            PitSpawn = values[2];
            TrapSpawn2 = values[3];
            TrapSpawn3 = values[4];
            PitSpawn2 = values[5];
            PitSpawn3 = values[6];
            Values = values;
            return Values;
        }

        public int[] SpawnCoins()
        {
            Random random = new Random();
            HashSet<int> usedNumbers = new HashSet<int>();

            while (usedNumbers.Count < 10)
            {
                usedNumbers.Add(random.Next(2, 30));
            }
            int[] values = new int[10];
            usedNumbers.CopyTo(values);
            Coins = values;
            return values;
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
            else if (PlayerLocation == TrapSpawn || PlayerLocation == TrapSpawn2 || PlayerLocation == TrapSpawn3)
            {
                
                return Hazards.Trap;
            }
            else if (PlayerLocation == PitSpawn || PlayerLocation == PitSpawn2 || PlayerLocation == PitSpawn3)
            {
                
                return Hazards.Pit;
            }
            
            return Hazards.Nothing;
        }
        public int CheckCoin(int cave)
        {
            PlayerLocation = cave;
            for (int i = 0; i < 10; i++)
            {
                if (Coins[i] == PlayerLocation)
                {
                    Coins[i] = 0;
                    return 1;
                }
            }
            return 0; // No coin found in the cave
        }

        public int[] GetCave(int adg1, int adg2, int adg3, int[] trappedLocations)
        {
            int NearTrap = 0;
            int NearWumpus = 0;
            int NearPit = 0;
            for (int i = 0; i < 7; i++)
            {
                if (trappedLocations[i] == adg1 || trappedLocations[i] == adg2 || trappedLocations[i] == adg3)
                {
                    if (trappedLocations[i] == TrapSpawn || trappedLocations[i] == TrapSpawn2 || trappedLocations[i] == TrapSpawn3)
                    {
                        NearTrap = 1;
                        
                    }
                    else if (trappedLocations[i] == WumpusSpawn)
                    {
                        NearWumpus = 1;
                        
                    }
                    else if (trappedLocations[i] == PitSpawn || trappedLocations[i] == PitSpawn2 || trappedLocations[i] == PitSpawn3)
                    {
                        NearPit = 1;  
                    }
                }
                
            }

            return [NearTrap, NearWumpus, NearPit];
            //if (adg1 == TrapSpawn || adg2 == TrapSpawn || adg3 == TrapSpawn || adg1 == TrapSpawn2)
            //{
            //    Near = 1;
            //    return Near;
            //}
            //if (adg1 == WumpusSpawn || adg2 == WumpusSpawn || adg3 == WumpusSpawn)
            //{
            //    Near = 2;
            //    return Near;
            //}
            //if (adg1 == PitSpawn || adg2 == PitSpawn || adg3 == PitSpawn)
            //{
            //    Near = 3;
            //    return Near;
            //}
            //else
            //{
            //    return 0;
            //}
        }


        private int[] Trapped()
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
            
            return [NewPlayerLocation, NewTrapspawn];
            TrapSpawn = NewTrapspawn;
        }

        public int ShootArrow(int ShootingInCave, int PlayerPos)
        {
            
            if (ShootingInCave == WumpusSpawn)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }





    }
}

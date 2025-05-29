using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            //Random random = new Random();
            //int Trapspawn = random.Next(2, 30);
            //int Trapspawn2 = random.Next(2, 30);
            //int Trapspawn3 = random.Next(2, 30);
            //int Wumpusspawn = random.Next(2, 30);
            //int Pitspawn = random.Next(2, 30);
            //int Pitspawn2 = random.Next(2, 30);
            //int Pitspawn3 = random.Next(2, 30);
            //while (Wumpusspawn == Trapspawn || Trapspawn == Pitspawn || Wumpusspawn == Pitspawn ||
            //    Wumpusspawn == Trapspawn2 || Wumpusspawn == Trapspawn3 || Wumpusspawn == Pitspawn2 ||
            //    Wumpusspawn == Pitspawn3 || Trapspawn == Pitspawn2 || Trapspawn == Pitspawn3 || Trapspawn2 == Pitspawn ||
            //    Trapspawn3 == Pitspawn || Trapspawn2 == Pitspawn2 || Trapspawn2 == Pitspawn3 || Trapspawn3 == Pitspawn2 || Pitspawn == Pitspawn2 || Pitspawn == Pitspawn3 || Pitspawn2 == Pitspawn3)
            //{
            //    if (Wumpusspawn == Trapspawn)
            //    {
            //        if (Wumpusspawn != 30)
            //        {
            //            Wumpusspawn += 1;
            //        }
            //        else
            //        {
            //            Wumpusspawn = 2;
            //        }
            //    }
            //    else if (Trapspawn == Pitspawn)
            //    {
            //        if (Pitspawn != 30)
            //        {
            //            Pitspawn += 1;
            //        }
            //        else
            //        {
            //            Pitspawn = 2;
            //        }

            //    }
            //    else if (Wumpusspawn == Pitspawn)
            //    {
            //        if (Wumpusspawn != 30)
            //        {
            //            Wumpusspawn += 1;
            //        }
            //        else
            //        {
            //            Wumpusspawn = 2;
            //        }

            //    }
            //    else if (Wumpusspawn == Trapspawn2)
            //    {
            //        if (Wumpusspawn != 30)
            //        {
            //            Wumpusspawn += 1;
            //        }
            //        else
            //        {
            //            Wumpusspawn = 2;
            //        }
            //    }
            //    else if (Wumpusspawn == Trapspawn3)
            //    {
            //        if (Wumpusspawn != 30)
            //        {
            //            Wumpusspawn += 1;
            //        }
            //        else
            //        {
            //            Wumpusspawn = 2;
            //        }
            //    }
            //    else if (Wumpusspawn == Pitspawn2)
            //    {
            //        if (Wumpusspawn != 30)
            //        {
            //            Wumpusspawn += 1;
            //        }
            //        else
            //        {
            //            Wumpusspawn = 2;
            //        }
            //    }
            //    else if (Wumpusspawn == Pitspawn3)
            //    {
            //        if (Wumpusspawn != 30)
            //        {
            //            Wumpusspawn += 1;
            //        }
            //        else
            //        {
            //            Wumpusspawn = 2;
            //        }
            //    }
            //    else if (Trapspawn == Trapspawn2)
            //    {
            //        if (Trapspawn != 30)
            //        {
            //            Trapspawn += 1;
            //        }
            //        else
            //        {
            //            Trapspawn = 2;
            //        }
            //    }
            //    else if (Trapspawn == Trapspawn3)
            //    {
            //        if (Trapspawn != 30)
            //        {
            //            Trapspawn += 1;
            //        }
            //        else
            //        {
            //            Trapspawn = 2;
            //        }
            //    }
            //    else if (Trapspawn == Pitspawn2)
            //    {
            //        if (Trapspawn != 30)
            //        {
            //            Trapspawn += 1;
            //        }
            //        else
            //        {
            //            Trapspawn = 2;
            //        }
            //    }
            //    else if (Trapspawn == Pitspawn3)
            //    {
            //        if (Trapspawn != 30)
            //        {
            //            Trapspawn += 1;
            //        }
            //        else
            //        {
            //            Trapspawn = 2;
            //        }
            //    }
            //    else if (PitSpawn == Pitspawn2)
            //    {
            //        if (Pitspawn2 != 30)
            //        {
            //            Pitspawn2 += 1;
            //        }
            //        else
            //        {
            //            Pitspawn2 = 2;
            //        }
            //    }
            //    else if (PitSpawn == Pitspawn3)
            //    {
            //        if (Pitspawn3 != 30)
            //        {
            //            Pitspawn3 += 1;
            //        }
            //        else
            //        {
            //            Pitspawn3 = 2;
            //        }
            //    }
            //    else if (Trapspawn2 == Trapspawn3)
            //    {
            //        if (Trapspawn3 != 30)
            //        {
            //            Trapspawn3 += 1;
            //        }
            //        else
            //        {
            //            Trapspawn3 = 2;
            //        }
            //    }      
            //}
            //WumpusSpawn = Wumpusspawn;
            //TrapSpawn = Trapspawn;
            //PitSpawn = Pitspawn;
            //TrapSpawn2 = Trapspawn2;
            //TrapSpawn3 = Trapspawn3;
            //PitSpawn2 = Pitspawn2;
            //PitSpawn3 = Pitspawn3;
            //return new int[] { Trapspawn, Wumpusspawn, Pitspawn, Trapspawn2, Trapspawn3, Pitspawn2, Pitspawn3 };


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
                Trapped();
                return Hazards.Trap;
            }
            else if (PlayerLocation == PitSpawn || PlayerLocation == PitSpawn2 || PlayerLocation == PitSpawn3)
            {
                return Hazards.Pit;
            }
            return Hazards.Nothing;
        }

        public int[] GetCave(int adg1, int adg2, int adg3)
        {
            int NearTrap = 0;
            int NearWumpus = 0;
            int NearPit = 0;
            for (int i = 0; i < 7; i++)
            {
                if (Values[i] == adg1 || Values[i] == adg2 || Values[i] == adg3)
                {
                    if (Values[i] == TrapSpawn || Values[i] == TrapSpawn2 || Values[i] == TrapSpawn3)
                    {
                        NearTrap = 1;
                        
                    }
                    else if (Values[i] == WumpusSpawn)
                    {
                        NearWumpus = 1;
                        
                    }
                    else if (Values[i] == PitSpawn || Values[i] == PitSpawn2 || Values[i] == PitSpawn3)
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

using System;
using System.Collections.Generic;
using System.Linq;
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
        public (int Wumpusspawn, int Batspawn, int Pitspawn) spawn()
        {
            Random random = new Random();
            int Batspawn = random.Next(1, 30);
            int Wumpusspawn = random.Next(1, 30);
            int Pitspawn = random.Next(1, 30);
            while (Wumpusspawn == Batspawn || Batspawn == Pitspawn || Wumpusspawn == Pitspawn)
            {
                if (Wumpusspawn == Batspawn)
                {
                    Wumpusspawn = +1;
                }
                else if (Batspawn == Pitspawn)
                {
                    Pitspawn = +1;
                }
                else if (Wumpusspawn == Pitspawn)
                {
                    Wumpusspawn = +1;
                }
            }
            return(Wumpusspawn,Batspawn, Pitspawn);
        }
           

        public void function2()
        {

        }
    }
}

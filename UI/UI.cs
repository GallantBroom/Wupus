using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI
{
    public class UI
    {
        public int currentRoom;
        public int[] connectedRooms;
       public UI(int currentroom, int[] connectedrooms ) { 
            
            currentRoom = currentroom;
            connectedRooms = connectedrooms; 




        
        }  


        public static int[] enablePossiblePathways(int currentRoom, int[] connectedrooms)
        {
            int[] abledPathways = new int[3];
            int[] direction = new int[3];
            if (currentRoom != 1 && currentRoom != 7 && currentRoom != 13 && currentRoom != 19 && currentRoom != 25 && currentRoom != 6 && currentRoom != 12 && currentRoom != 18 && currentRoom != 24 && currentRoom != 30)
            {
                for (int i = 0; i < connectedrooms.Length; i++)
                {
                    abledPathways[i] = connectedrooms[i] - currentRoom;

                    if (abledPathways[i] == -6 || abledPathways[i] == 23 || abledPathways[i] == 29)
                    {

                        direction[i] = 0;
                    }
                    if (abledPathways[i] == -5 || abledPathways[i] == -11 || abledPathways[i] == 24)
                    {

                        direction[i] = 1;
                    }
                    if (abledPathways[i] == 1)
                    {

                        direction[i] = 2;
                    }
                    if (abledPathways[i] == 6 || abledPathways[i] == -23 || abledPathways[i] == -29)
                    {

                        direction[i] = 3;
                    }
                    if (abledPathways[i] == 5 || abledPathways[i] == -24 || abledPathways[i] == 11)
                    {

                        direction[i] = 4;
                    }
                    if (abledPathways[i] == -1)
                    {

                        direction[i] = 5;
                    }
                }


                return direction;
            }
            else
            {
                for (int i = 0; i < connectedrooms.Length; i++)
                {
                    abledPathways[i] = connectedrooms[i] - currentRoom;

                    if (abledPathways[i] == -6 || abledPathways[i] == 23 || abledPathways[i] == 29)
                    {

                        direction[i] = 0;
                    }
                    if (abledPathways[i] == -11 || abledPathways[i] == 24)
                    {

                        direction[i] = 1;
                    }
                    if (abledPathways[i] == -5)
                    {

                        direction[i] = 2;
                    }
                    if (abledPathways[i] == 6 || abledPathways[i] == -23 || abledPathways[i] == -29)
                    {

                        direction[i] = 3;
                    }
                    if (abledPathways[i] == -24 || abledPathways[i] == 11)
                    {

                        direction[i] = 4;
                    }
                    if (abledPathways[i] == 5)
                    {

                        direction[i] = 5;
                    }
                }


                return direction;


            }
            
        }



    }
}

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


        public static int[] findCorrectDirection(int[] connectingRooms, int currentRoom)
        {
            int[] ablePathways = new int[connectingRooms.Length];
            int[] directions = new int[connectingRooms.Length];



            for (int i = 0; i < connectingRooms.Length; i++)
            {
                if (connectingRooms[i] != 0)
                {
                    ablePathways[i] = connectingRooms[i] - currentRoom;
                }

                if (ablePathways[i] == 29 || ablePathways[i] == 23 || ablePathways[i] == -6)
                {
                    directions[i] = 1;

                }
                else if (ablePathways[i] == -11 || ablePathways[i] == 24)
                {
                    directions[i] = 2;
                }
                else if (ablePathways[i] == 1)
                {

                    directions[i] = 3;
                }
                else if(ablePathways[i] == -5)
                {
                    for(int j = 0; j < 31; j+= 6)
                    {
                        if (currentRoom == j)
                        {
                            directions[i] = 3;
                            break;
                        }
                        else if (currentRoom != j)
                        {
                            directions[i] = 2;
                        }
                    }
                }
                else if (ablePathways[i] == 6 || ablePathways[i] ==-23 || ablePathways[i] ==-29)
                {
                    directions[i] = 4;
                }
                else if (ablePathways[i] == -24 || ablePathways[i] == 11)
                {
                    directions[i] = 5;
                }
                else if (ablePathways[i] == -1)
                {
                    directions[i] = 6;
                }

                else if (ablePathways[i] == 5)
                {

                    for (int j = 1; j < 26; j+= 6)
                    {
                        if (currentRoom == j)
                        {
                            directions[i] = 6;
                            break;
                        }
                        else if (currentRoom != j)
                        {
                            directions[i] = 5;
                        }
                    }

                }
                






            }


            return directions;
        }

       



    }
}

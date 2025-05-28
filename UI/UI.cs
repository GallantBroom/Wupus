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
                ablePathways[i] = connectingRooms[i] - currentRoom;

                if (ablePathways[i] == 29)
                {
                    directions[i] = 1;

                }
                else
                {
                    if (ablePathways[i] == 5 || ablePathways[i] == -5)
                    {
                        for (int k = 1; k < 26; k += 6)
                        {

                            if (currentRoom == k)
                            {


                                if (ablePathways[i] == 5)
                                {
                                    directions[i] = 6;
                                    break;

                                }

                            }
                            else if (currentRoom != k && ablePathways[i] == 5)
                            {
                                directions[i] = 5;
                            }

                        }

                        for (int j = 6; j < 30; j += 6)
                        {

                            if (currentRoom == j)
                            {

                                if (ablePathways[i] == -5)
                                {
                                    directions[i] = 3;

                                }

                            }
                            else if (currentRoom != j && ablePathways[i] == -5)

                            {
                                directions[i] = 2;
                            }

                        }

                    }

                    else if (ablePathways[i] == 6 || ablePathways[i] == -23 || ablePathways[i] == -29)
                    {

                        directions[i] = 1;
                    }
                    else if (ablePathways[i] == 1)
                    {

                        directions[i] = 3;
                    }
                    else if (ablePathways[i] == 6)
                    {

                        directions[i] = 4;
                    }
                    else if (ablePathways[i] == -1)
                    {

                        directions[i] = 6;

                    }
                    else if (ablePathways[i] == -11)
                    {

                        directions[i] = 2;
                    }

                }






            }


            return directions;
        }

       



    }
}

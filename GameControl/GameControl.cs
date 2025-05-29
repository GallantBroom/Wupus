using GameLocation;
using High_Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace GameControl
{
    public class GameControl
    {

        public bool isPlayerTrapped = false;

        public GameControl() { 
        
                
        
         }
        //start the game, go to the cave
        public void startGame()
        {
            int cavenumber = 1;



            //Cave.Cave cave = new Cave.Cave();


            getConnectingRooms(cavenumber,1);





        }
        // end the game, go back to the menu screen
        public void GameLose()
        {
           
           


        }

        public void GameWin()
        {




        }
        

        
        
        public string displayHighScores(string userName,string score, string position)
        {


            









            return userName;

        }
        
        public int[] giveHintsToUI()
        {
            GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
            int[] near = gameLocation.GetCave(6, 30, 2);

            


            return near;
        }

        
        public int[] giveUIHazards(int[] connectingRooms)
        {

            GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();

            int[] hazards = gameLocation.GetCave(connectingRooms[0], connectingRooms[1], connectingRooms[2]);







            return hazards;
            



        }

        //the player has encouintered a room with a trap. Find what trap it is and do the nessesary thing
        public int playerWasTrapped(int cave,int room)
        {
            GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
            if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Trap)
            {
                //i need to tell UI to move the player to a different room 
               
                room = gameLocation.PlayerLocation;
                isPlayerTrapped = true;






            }
            else if(gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Wumpus)
            {
                
            }
            else if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Pit)
            {
                GameLose();
                
            }

            return room;

        }

        //Find the connecting rooms for the player, given the cave number and the current room
        public static int[] getConnectingRooms(int caveNumber, int currentRoom)
        {
            Cave.Cave cave1 = new Cave.Cave();

            int[] cave = cave1.GiveCave(caveNumber - 1, currentRoom - 1);






            return cave;
        }

        //ask player class what the player's inventory is, what their score is and then show it on the UI
       public static void updateInventory()
        {

            

            





        }

     


       



    }
}

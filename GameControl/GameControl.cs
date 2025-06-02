 using GameLocation;
using High_Score;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace GameControl
{
    public class GameControl
    {

        public bool isPlayerTrapped = false;
        GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
        High_Score.High_Score highScore = new High_Score.High_Score();
        Player.PlayerClass player = new Player.PlayerClass();


        public GameControl() { 
        
                
        
         }
        //start the game, go to the cave
        public int[] startGame(int cavenumber)
        {
           

            int[] values = gameLocation.Spawn();

            //Cave.Cave cave = new Cave.Cave();


            getConnectingRooms(cavenumber,1);



            return values;

        }
         
        // end the game, go back to the menu screen
        

        public void GameWin()
        {




        }
        

        
        
        public PlayerScore displayHighScores(bool killedWumpus, int cave, string playerName)
        {
            
          int playerScore = player.GetScore(killedWumpus);
            
            PlayerScore playerScoreObj = new PlayerScore(playerName, (ulong)playerScore, cave);























            return playerScoreObj;

        }
        
        public void giveHintsToUI()
        {
            //int[] near = gameLocation.GetCave(6, 30, 2);
        }

        
        public int[] giveUIHazards(int[] connectingRooms, int[] trappedLocations)
        {

            



            int[] hazards = gameLocation.GetCave(connectingRooms[0], connectingRooms[1], connectingRooms[2], trappedLocations);







            return hazards;
            



        }


        //public int playerWasTrapped(int cave, int room)
        //{

            //if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Trap)
            //{

                //if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Trap)
                //{

                //i need to tell UI to move the player to a different room 

                //room = gameLocation.PlayerLocation;
                // isPlayerTrapped = true;







            //}
            //else if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Wumpus)
            //{
                //GameLose();
            //}
            //else if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Pit)
            //{

            //}
        //}
                

           // }
           // else if(gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Wumpus)
           // {
                
           // }
            //else if (gameLocation.PlayerMove(cave) == GameLocation.GameLocation.Hazards.Pit)
           // {
              //  GameLose();

                
           // }

           // return room;

       // }

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

     
       public void FellInPit()
        {
            
        }





    }
}

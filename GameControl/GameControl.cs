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

        High_Score.High_Score highscore = new High_Score.High_Score();
        


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

        
        public int[] giveUIHazards()
        {

            GameLocation.GameLocation gameLocation = new GameLocation.GameLocation();
            Cave.Cave cave = new Cave.Cave();



            //int[] hazards = gameLocation.Spawn();
            int[] hazards = { 0, 0, 0 };
            


            return hazards;
            



        }

        public void playerWasTrapped(int newPlayerLocation, int trappedSpawned)
        {
          
            
        }

        public static int[] getConnectingRooms(int caveNumber, int currentRoom)
        {
            Cave.Cave cave1 = new Cave.Cave();

            int[] cave = cave1.GiveCave(caveNumber - 1, currentRoom - 1);






            return cave;
        }

       public static void playerMovesRooms()
        {

            

            





        }

     


       



    }
}

using High_Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameControl
{
    public class GameControl
    {
        


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
        //the game is puased, make sure that the pause menu is played
        public void PauseGame()
        {

            
        }

        
        
        public string displayHighScores(string userName,string score, string position)
        {
             
            
           


            return userName;



        }
        
        public void displaySplashScreen()
        {




        }

        public void displayCurrentRoom()
        {




        }
        public void pitFall()
        {





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

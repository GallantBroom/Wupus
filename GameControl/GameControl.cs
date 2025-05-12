using High_Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;


namespace GameControl
{
    public class GameControl
    {
        


        public GameControl() { 
        
                
        
         }
        //start the game, go to the cave
        public void startGame()
        {
            WumpusStart StartMenuDLG = new WumpusStart();


            StartMenuDLG.ShowDialog();





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
             
            
            UI.HighScore highScoreDLG = new UI.HighScore();
            //display the splash screen, need to use the new variable name

            highScoreDLG.ShowDialog();


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
            caveNumber = 1;
            currentRoom = 1;

            int [] cave = cave1.GiveCave(caveNumber,currentRoom);
            





            return cave;
        }

     


       



    }
}

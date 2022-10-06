using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2.Classes
{
    public class Game
    {
        
        
        int result = 0;
        Player player = new Player();
        ComputerPlayer playerComputer = new ComputerPlayer();
        
        
        public int PlayerBullets()
        {
            
            return player.Bullets;
            
        }
        public int CPUBullets()
        {
            
            return playerComputer.Bullets;
            
        }
        public void PlayerChoice(string choice)
        {
            player.Choice = choice;
            GameChoice();
        }
        public void CPUChoice()
        {
            int choice = ComputerPlayer.GameRoundCPU(playerComputer.Bullets);
            if (choice == 0)
            {
                playerComputer.Choice = "load";
            }
            else if (choice == 1)
            {
                playerComputer.Choice = "block";
            }
            else if (choice == 2)
            {
                playerComputer.Choice = "shoot";
            }
            else if (choice == 3)
            {
                playerComputer.Choice = "shotgun";
            }

        }
        public string ComputerChoice()
        {
            return playerComputer.Choice;
        }
        public bool PlayerWon()
        {
            if(result == 1)
            {
                return true;

            }
            else return false;
        }
        public bool ComputerWon()
        {
            if (result == 2)
            {
                return true;
            }
            else return false;
        }
        //Enemy choices : 0 = load, 1 = block, 2 = shoot, 3 = shotgun
        //Result : 0 = draw, 1 = player wins, 2 = CPU wins, , 3 = player loses bullet,
        //4 = cpu loses bullet, 5 = both lose bullet, 6 = player gets bullet, 7 = cpu gets bullet
        //8 = both gets bullet
        public void UpdateCPUBullets()
        {
            
            
            if (result == 7 || result == 8)
            {
                playerComputer.Bullets++;
            }
            else if(result == 4 || result == 5)
            {
                playerComputer.Bullets--;
            }
            else if (result == 1|| result == 2)
            {
                playerComputer.Bullets = 0;
            }
            
        }
        public void UpdatePlayerBullets()
        {
            
            //int bulletResult = GameRoundCPU(newBullet);
            if (result == 6 || result == 8)
            {
                player.Bullets++;
            }
            else if (result == 3 || result == 5)
            {
                player.Bullets--;
            }
            else if (result == 1 || result == 2)
            {
                player.Bullets = 0;
            }

        }
            

        public void GameChoice()
        {
            //Enemy choices : 0 = load, 1 = block, 2 = shoot, 3 = shotgun
            //Result : 0 = draw, 1 = player wins, 2 = CPU wins, , 3 = player loses bullet,
            //4 = cpu loses bullet, 5 = both lose bullet, 6 = player gets bullet, 7 = cpu gets bullet
            //8 = both gets bullet
            CPUChoice();
            
            if ( player.Choice == "load")
            {
               if(playerComputer.Choice == "load")
                {
                    result = 8;
                }
               else if (playerComputer.Choice == "block")
                {
                    result = 6;
                }
               else if(playerComputer.Choice == "shoot")
                {
                    result = 2;
                }
               else if(playerComputer.Choice == "shotgun")
                {
                    result = 2;
                }

            }
            //Enemy choices : 0 = load, 1 = block, 2 = shoot, 3 = shotgun
            //Result : 0 = draw, 1 = player wins, 2 = CPU wins, 3 = player loses bullet,
            //4 = cpu loses bullet, 5 = both lose bullet, 6 = player gets bullet, 7 = cpu gets bullet
            //8 = both gets bullet
            else if (player.Choice == "shoot")
            {
                if (playerComputer.Choice == "load"){
                    result = 1;
                }
                else if(playerComputer.Choice == "block")
                {
                    result = 3;
                }
                else if(playerComputer.Choice == "shoot")
                {
                    result = 5;
                }
                else if (playerComputer.Choice == "shotgun")
                {
                    result = 2;
                }

            }
            //Enemy choices : 0 = load, 1 = block, 2 = shoot, 3 = shotgun
            //Result : 0 = draw, 1 = player wins, 2 = CPU wins, 3 = player loses bullet,
            //4 = cpu loses bullet, 5 = both lose bullet, 6 = player gets bullet, 7 = cpu gets bullet
            //8 = both gets bullet
            else if (player.Choice == "block")
            {
                if (playerComputer.Choice == "load")
                {
                    result = 7;
                }
                else if (playerComputer.Choice == "block")
                {
                    result = 0;
                }
                else if (playerComputer.Choice == "shoot")
                {
                    result = 4;
                }
                else if (playerComputer.Choice == "shotgun")
                {
                    result = 2;
                }

            }
            else if (player.Choice == "shotgun")
            {
                result = 1;
            }
            UpdateCPUBullets();
            UpdatePlayerBullets();
            
        }

        
    }
}

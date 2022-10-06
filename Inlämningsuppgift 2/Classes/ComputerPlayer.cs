using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2.Classes
{
    public class ComputerPlayer : Player
    {
        private static Random CPUChoice = new Random();
        public static int GameRoundCPU(int enemyBullet)
        {
            //Enemy choices : 0 = load, 1 = block, 2 = shoot, 3 = shotgun
            int enemyChoice = 0;
            if (enemyBullet == 0)
            {
                int randomChoice = CPUChoice.Next(0, 2);
                if (randomChoice == 1)
                {
                    enemyChoice = 1;
                }
            }
            if (enemyBullet > 0 && enemyBullet < 3)
            {
                int randomChoice = CPUChoice.Next(0, 3);
                if (randomChoice == 1)
                {
                    enemyChoice = 1;
                }
                else if (randomChoice == 2)
                {
                    enemyChoice = 2;
                }
            }
            if (enemyBullet >= 3)
                enemyChoice = 3;
            return enemyChoice;
        }
    }
}

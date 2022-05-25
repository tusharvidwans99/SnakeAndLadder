using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class startGame
    {
        public static void GameStarted()
        {

            int Players = 1;
            int Player1_Position = 0;
            int[] LadderStart = { 4, 13, 33, 42, 50, 62, 74};
            int[] SnakeStart = { 99, 89, 76, 66, 54, 43, 40, 27 };

            Console.WriteLine($"Player Position: {Player1_Position}");

            Random random = new Random();
            int RollDie = random.Next(6) + 1;
            Console.WriteLine($"Rolling Die: {RollDie}");
            
        }
    }
}

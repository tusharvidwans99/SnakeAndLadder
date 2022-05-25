using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class startGame
    {
        static int Players = 1;
        static int Player1_Position = 0;
        static int[] LadderStart = { 4, 13, 33, 42, 50, 62, 74 };
        static int[] SnakeStart = { 99, 89, 76, 66, 54, 43, 40, 27 };
        public static void GameStarted()
        {

            int DieCount = 0;

            Console.WriteLine($"Player Position: {Player1_Position}");

            Random random = new Random();
            
            

            while(Player1_Position != 100 || Player1_Position > 100)
            {
                int RollDie = random.Next(6) + 1;
                DieCount++;
                Console.WriteLine($"Rolling Die: {RollDie}");
                
                if (Player1_Position + RollDie > 100)
                {

                    Console.WriteLine($"No_PLay because Player Position+Die: {Player1_Position+RollDie} number is greater that 100\n");

                }
                else if (isLadder(Player1_Position + RollDie))
                {
                    int LadderEnd = random.Next(8) + 10;
                    Console.WriteLine($"Taking Ladder of {LadderEnd} Points from {Player1_Position + RollDie} to {(Player1_Position + RollDie) + LadderEnd}");
                    Player1_Position = (Player1_Position + RollDie) + LadderEnd;
                }
                else if (isSnake(Player1_Position + RollDie))
                {
                    int SnakeEnd = random.Next(8) + 10;
                    Console.WriteLine($"Snake Eating of {SnakeEnd} Points from {Player1_Position + RollDie} to {(Player1_Position + RollDie) - SnakeEnd}");
                    Player1_Position = (Player1_Position + RollDie) - SnakeEnd;
                }
                else
                {
                    Console.WriteLine($"No snake No Ladder Moving Ahead by {RollDie}");
                    Player1_Position += RollDie;
                }
                Console.WriteLine($"Player Position:{Player1_Position}\n");

            }
            Console.WriteLine("Goal Reached by Player1");
            Console.WriteLine($"To win the Game Player need to Roll the dice for {DieCount} times");
        }
        
        public static bool isLadder(int position)
        {
            for( int i=0; i<LadderStart.Length;i++)
            {

                if(LadderStart[i] == position)
                {
                    return true;
                }
            }
            return false;
        }
        
        
        public static bool isSnake(int position)
        {
            for(int i = 0; i < SnakeStart.Length; i++)
            {
                if(SnakeStart[i] == position)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

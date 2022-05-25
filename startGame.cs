using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class startGame
    {
        static int Player1_Position = 0;
        static int Player2_Position = 0;
        static int[] LadderStart = { 4, 13, 33, 42, 50, 62, 74 };
        static int[] SnakeStart = { 99, 89, 76, 66, 54, 43, 40, 27 };
        static int flag=0;
        static Random random = new Random();
        public static void GameStarted()
        {
            int die1 = 0, die2 = 0;
            Console.WriteLine($"Player1 Position: {Player1_Position}");
            Console.WriteLine($"Player2 Position: {Player2_Position}\n");
            while(Player1_Position < 100 && Player2_Position < 100)
            {
                do
                {
                    Console.WriteLine($"Player 1 is running, Position:{Player1_Position}");
                    Player1_Position = playgame(Player1_Position);
                    die1++;
                    Console.WriteLine($"PLayer 1 Position: {Player1_Position}\n");
                }
                while (flag == 1);
                do
                {
                    Console.WriteLine($"Player 2 is running, Position:{Player2_Position}");
                    Player2_Position = playgame(Player2_Position);
                    die2++;
                    Console.WriteLine($"Player 2 Position: {Player2_Position}\n");
                }while (flag == 1);
                
            }

            if (Player1_Position == 100)
            {
                Console.WriteLine($"Goal Reached by Player 1 and to win game Player has to roll dice {die1} times");
            }
            else
            {
                Console.WriteLine($"Goal Reached by Player 2 and to win game Player has to roll dice {die2} times");
            }
        }

        public static int playgame(int Player)
        {
            flag = 0;
            int RollDie = random.Next(6) + 1;
            Console.WriteLine($"Rolling Die: {RollDie}");

            if (Player + RollDie > 100)
            {

                Console.WriteLine($"No_PLay because Player Position+Die: {Player + RollDie} number is greater that 100");

            }
            else if (isLadder(Player + RollDie))
            {
                int LadderEnd = random.Next(8) + 10;
                Console.WriteLine($"Taking Ladder of {LadderEnd} Points from {Player + RollDie} to {(Player + RollDie) + LadderEnd}");
                Player = (Player + RollDie) + LadderEnd;
                flag = 1;
                
            }
            else if (isSnake(Player1_Position + RollDie))
            {
                int SnakeEnd = random.Next(8) + 10;
                Console.WriteLine($"Snake Eating of {SnakeEnd} Points from {Player + RollDie} to {(Player + RollDie) - SnakeEnd}");
                Player = (Player + RollDie) - SnakeEnd;
            }
            else
            {
                Console.WriteLine($"No snake No Ladder, Moving Ahead by {RollDie}");
                Player += RollDie;
            }
            
            return Player;
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

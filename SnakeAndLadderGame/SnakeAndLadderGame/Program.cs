using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Game.");
            SnakeAndLadder player = new SnakeAndLadder();
            player.DieRoll();
            player.Check();
        }
    }
}

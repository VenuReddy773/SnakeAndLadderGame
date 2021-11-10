using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeAndLadder
    {
        public int playerPosition = 0;
        public void DieRoll()
        {
            Random random = new Random();
            int Dice = random.Next(1, 7);           
            Console.WriteLine("Rolled Die is:" + Dice);
        }
    }       
}

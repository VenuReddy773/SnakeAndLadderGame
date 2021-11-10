﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public int playerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int dice = random.Next(1, 7);
            return dice;            
        }
        public void Check()
        {
            int dieRoll = this.DieRoll();
            int option = random.Next(0, 3);
            switch(option)
            {
                case SNAKE:
                    this.playerPosition -= dieRoll;
                    break;
                case LADDER:
                    this.playerPosition += dieRoll;
                    break;
                case NO_PLAY:
                    break;
            }            
        }
    }       
}

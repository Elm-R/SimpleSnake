using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake
{

    public enum Direction 
    {
        Up, 
        Down,
        Left,
        Right
    };

    internal class Settings
    {
        // store global settings of the game

        // static? access them from other classes without the need of creating new settings objects
        public static int Width { get; set; } // width of the circle in pixels
        public static int Height { get; set; } // height of the circle in pixels
        public static int Speed { get; set; } // speed of the snake
        public static int Score { get; set; } // total score
        public static int Points { get; set; } // points earned by food consumption
        public static bool GameOver { get; set; } 

        public static Direction direction { get; set; }


        public Settings()
        {
            Width = 16; 
            Height = 16; 
            Speed = 16; 
            Score = 0; 
            Points = 100;
            GameOver = false;
            direction = Direction.Down;


        }


    }
}

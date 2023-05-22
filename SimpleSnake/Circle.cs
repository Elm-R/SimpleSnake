using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake
{
    internal class Circle
    {
        // 1 circle for a food object and multiple circles for the snake 


        // for access from other classes
        public int X { get; set; }

        public int Y { get; set; }

        public Circle()
        {

            X = 0;

            Y = 0;

        }


}
}

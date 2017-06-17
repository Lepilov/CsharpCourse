using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public ConsoleColor Color { get; set; }

        public Shape(int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public abstract void Draw(int ticks);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Rectangle : Shape
    {
        public Rectangle(int x, int y, ConsoleColor color = ConsoleColor.White)
            : base(x, y, color)
        {
        }

        public override void Draw(int ticks)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    SingletonEngine2D.SetPixel(this.X + i, this.Y + j, this.Color = ConsoleColor.White);
                }
            }
        }
    }
}

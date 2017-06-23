using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class RightTriangle : Shape
    {
        Decorator d = new Decorator();
        public RightTriangle(int x, int y, ConsoleColor color = ConsoleColor.White)
            : base(x, y, color)
        {
        }

        public override void Draw(int ticks)
        {          
            d.Message();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i >= j && i >= 6 - j)
                    {
                        SingletonEngine2D.SetPixel(this.X + i, this.Y + j, this.Color = ConsoleColor.Yellow);
                    }
                }
            }
        }
    }
}

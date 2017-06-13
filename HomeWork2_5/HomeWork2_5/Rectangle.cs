using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    class Rectangle : Shape
    {
        public Rectangle(int x, int y, ConsoleColor color = ConsoleColor.White) 
            : base(x, y, color)
        {
        }

        public override void Draw(int ticks)
        {
            this.X++;
            if (this.X > 30)
            {
                this.X = 20;
            }
            if (ticks % 2 == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Engine2D.SetPixel(this.X + i, this.Y + j, this.Color = ConsoleColor.White);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if ((j >= i && j >= 6 - i) || (j <= i && j <= 6 - i))
                            Engine2D.SetPixel(this.X + i, this.Y + j, this.Color = ConsoleColor.Red);
                    }
                }
            }
        }
    }
}

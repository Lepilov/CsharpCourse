using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    class Square : Shape
    {
        public Square(int x, int y, ConsoleColor color = ConsoleColor.White)
            : base(x, y, color)
        {
        }

        public override void Draw(int ticks)
        {
            this.X++;
            if (this.X > 40)
            {
                this.X = 30;
            }
            if (ticks % 2 == 1)
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if (j >= i)
                        {
                            Engine2D.SetPixel(this.X + i, this.Y + j, this.Color = ConsoleColor.Green);
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if (j <= i)
                        {
                            Engine2D.SetPixel(this.X + i, this.Y + j, this.Color = ConsoleColor.Cyan);
                        }
                    }
                }
            }
        }
    }
}
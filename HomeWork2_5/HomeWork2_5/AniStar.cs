using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    class AniStar : Shape
    {
        public AniStar(int x, int y, ConsoleColor color = ConsoleColor.White) 
            : base(x, y, color)
        {
        }

        public override void Draw(int ticks)
        {
            this.X++;
            if (this.X > 70)
            {
                this.X = 10;
            }

            if (ticks % 2 == 1)
            {
                Engine2D.SetPixel(this.X - 1, this.Y - 1, this.Color);
                Engine2D.SetPixel(this.X + 1, this.Y - 1, this.Color);
                Engine2D.SetPixel(this.X - 1, this.Y + 1, this.Color);
                Engine2D.SetPixel(this.X + 1, this.Y + 1, this.Color);
                Engine2D.SetPixel(this.X, this.Y, this.Color);
            }
            else
            {
                Engine2D.SetPixel(this.X - 1, this.Y, this.Color);
                Engine2D.SetPixel(this.X + 1, this.Y, this.Color);
                Engine2D.SetPixel(this.X, this.Y - 1, this.Color);
                Engine2D.SetPixel(this.X, this.Y + 1, this.Color);
                Engine2D.SetPixel(this.X, this.Y, this.Color);
            }
        }
    }
}

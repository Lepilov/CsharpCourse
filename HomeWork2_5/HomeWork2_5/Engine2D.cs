using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    static class Engine2D
    {
        public static void Draw(IEnumerable<Shape> shapes)
        {
            while (true)
            {
                Engine2D.Clear();
                foreach (var shape in shapes)
                {
                    shape.Draw(Ticks);
                }
                Thread.Sleep(250);
                Ticks++;
            }         
        }

        public static int Ticks { get; private set; }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void SetPixel(int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
    }
}

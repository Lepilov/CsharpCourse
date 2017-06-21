using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pattern
{
    class SingletonEngine2D
    {
        private static SingletonEngine2D instance;

        protected SingletonEngine2D() { }

        public static SingletonEngine2D Instance()
        {
            if (instance == null)
            {
                instance = new SingletonEngine2D();
            }

            return instance;
        }

        public static void Draw(IEnumerable<Shape> s)
        {
            while (true)
            {
                Clear();
                foreach (var shape in s)
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

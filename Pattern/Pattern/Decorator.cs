using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class Decorator
    {
        public void Message()
        {
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Фигура");
        }
    }
}

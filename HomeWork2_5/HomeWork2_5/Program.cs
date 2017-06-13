using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine2D.Draw(
                new Shape[]
                {
                    //new Star(2, 2, ConsoleColor.Red),
                    //new Star(10, 10, ConsoleColor.White),
                    //new AniStar(20, 20, ConsoleColor.Blue),
                    new Triangle(50, 10),
                    new Rectangle(50, 10),
                    new Square(50, 10)
                });

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Shape shape = null;

            creator = new TriangleCreator();
            shape = creator.FactoryMethod();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class TriangleCreator : Creator
    {
        public TriangleCreator(Shape shape) 
            : base(shape)
        {
        }

        public override Shape FactoryMethod()
        {
            return new RightTriangle(5, 5, ConsoleColor.Blue);
        }
    }
}

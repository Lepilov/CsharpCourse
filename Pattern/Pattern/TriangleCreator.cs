using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class TriangleCreator : Creator
    {
        public override Shape FactoryMethod()
        {
            return new RightTriangle();
        }
    }
}

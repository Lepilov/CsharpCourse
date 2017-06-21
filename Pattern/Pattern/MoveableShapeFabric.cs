using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class MoveableShapeFabric : ShapeFabricFabric
    {
        public override Shape CreatorRectangle(int x, int y)
        {
            return new MoveRectangle(x, y);
        }

        public override Shape CreatorTriangle(int x, int y)
        {
            return new MoveTriangle(x, y);
        }
    }
}

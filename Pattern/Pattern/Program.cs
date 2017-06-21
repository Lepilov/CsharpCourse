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
            ShapeFabricFabric s1 = new StaticShapeFabric();
            ShapeFabricFabric s2 = new MoveableShapeFabric();

            SingletonEngine2D.Draw(new Shape[]
            {
                s1.CreatorRectangle(5,5),
                s1.CreatorTriangle(10, 10),
                s2.CreatorRectangle(15, 15),
                s2.CreatorTriangle(20, 20)
            });
        }
    }
}

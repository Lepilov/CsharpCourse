using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class ShapeFabricFabric //: IEnumerable<Shape>
    {
        public abstract Shape CreatorTriangle(int x, int y);
        public abstract Shape CreatorRectangle(int x, int y);

        //public IEnumerator<Shape> GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}
    }
}

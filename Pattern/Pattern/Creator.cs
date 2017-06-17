using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class Creator
    {
        private Shape shape;

        public Creator(Shape shape)
        {
            this.shape = shape;
        }

        public abstract Shape FactoryMethod();
    }
}

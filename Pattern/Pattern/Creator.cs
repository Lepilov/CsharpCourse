using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class Creator
    {
        Shape shape;
        public abstract Shape FactoryMethod();
    }
}

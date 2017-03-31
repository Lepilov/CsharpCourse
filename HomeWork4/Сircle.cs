using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Circle : Figure
    {
        private float radiusCircle;

        public Circle(float radiusCircle, string name)
            :base(name)
        {
            this.radiusCircle = radiusCircle;
        }

        public override float PerimeterFigure()
        {
            return 2 * (float)Math.PI * radiusCircle;
        }

        public override float SquareFigure()
        {
            return (float)(Math.PI * Math.Pow(radiusCircle, 2));
        }
    }
}

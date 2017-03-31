using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Sector : Figure
    {
        private float radiusOfAnAngle;
        private float radiusCircle;

        public Sector(float radiusOfAnAngle, float radiusCircle, string name)
            :base(name)
        {
            this.radiusOfAnAngle = radiusOfAnAngle;
            this.radiusCircle = radiusCircle;
        }

        public override float PerimeterFigure()
        {
            return (radiusOfAnAngle + 2) * radiusCircle;
        }

        public override float SquareFigure()
        {
            return (float)(Math.Pow(radiusOfAnAngle, 2) * radiusCircle) / 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Rectangle : Figure
    {
        private float lengthRectangle;
        private float widthRectangle;

        public Rectangle(float lengthRectangle, float widthRectangle, string name)
            :base(name)
        {
            this.lengthRectangle = lengthRectangle;
            this.widthRectangle = widthRectangle;
        }

        public override float PerimeterFigure()
        {
            return (lengthRectangle + widthRectangle) * 2;
        }

        public override float SquareFigure()
        {
            return lengthRectangle * widthRectangle;
        }
    }
}

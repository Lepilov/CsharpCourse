using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Triangle : Figure
    {
        private float firstPartyTriangle;
        private float secondPartyTriangle;
        private float thirdPartyTriangle;

        public Triangle(float firstPartyTriangle, float secondPartyTriangle, float thirdPartyTriangle, string name)
            :base(name)
        {
            this.firstPartyTriangle = firstPartyTriangle;
            this.secondPartyTriangle = secondPartyTriangle;
            this.thirdPartyTriangle = thirdPartyTriangle;
        }

        public override float PerimeterFigure()
        {
            return firstPartyTriangle + secondPartyTriangle + thirdPartyTriangle;
        }

        public override float SquareFigure()
        {
            float perimeterFigure = PerimeterFigure() / 2;
            return (float)(Math.Sqrt(perimeterFigure * ((perimeterFigure - firstPartyTriangle) * (perimeterFigure - secondPartyTriangle) * (perimeterFigure - thirdPartyTriangle))));

        }
    }
}

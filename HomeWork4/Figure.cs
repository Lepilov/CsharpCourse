using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Figure
    {
        protected string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public void FigureName()
        {
            Console.WriteLine($"Фигура : {name}");
        }

        public virtual float PerimeterFigure()
        {
            return default(float);
        }

        public virtual float SquareFigure()
        {
            return default(float);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure rectangle = new Rectangle(5, 6, "Прямоугольник");
            rectangle.FigureName();
            Console.WriteLine($"Периметр : {rectangle.PerimeterFigure()}");
            Console.WriteLine($"Площадь : {rectangle.SquareFigure()}");
            Console.WriteLine(new string('-', 20));

            Figure triangle = new Triangle(5, 8, 10, "Треугольник");
            triangle.FigureName();
            Console.WriteLine($"Периметр : {triangle.PerimeterFigure()}");
            Console.WriteLine($"Площадь : {triangle.SquareFigure()}");
            Console.WriteLine(new string('-', 20));

            Figure circle = new Circle(4, "Круг");
            circle.FigureName();
            Console.WriteLine($"Периметр : {circle.PerimeterFigure()}");
            Console.WriteLine($"Площадь : {circle.SquareFigure()}");
            Console.WriteLine(new string('-', 20));

            Figure sector = new Sector(20, 40, "Сектор");
            sector.FigureName();
            Console.WriteLine($"Периметр : {sector.PerimeterFigure()}");
            Console.WriteLine($"Площадь : {sector.SquareFigure()}");

            Console.Read();
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк матрицы : ");
            uint numberOfRows = UInt32.Parse(Console.ReadLine());

            Console.Write("Ведите кол-во столбцов матрицы : ");
            uint numberOfCols = UInt32.Parse(Console.ReadLine());

            Random random = new Random();
            Matrix firstMatrix = new Matrix(numberOfRows, numberOfCols);
            Matrix secondMatrix = new Matrix(numberOfRows, numberOfCols);
            for (uint i = 0; i < numberOfRows; i++)
            {
                for (uint j = 0; j < numberOfCols; j++)
                {
                    firstMatrix[i, j] = random.Next(1, 4);
                    secondMatrix[i, j] = random.Next(1, 4);
                }
            }

            Console.WriteLine("Перва матрица : ");
            firstMatrix.PrintMatrix();

            Console.WriteLine("Вторая матрица : ");
            secondMatrix.PrintMatrix();

            Console.WriteLine("Сложение двух матриц : ");
            (firstMatrix + secondMatrix).PrintMatrix();

            Console.WriteLine("Сложение матрицы на число : ");
            (firstMatrix + 3).PrintMatrix();

            Console.WriteLine("Умножение двух матриц : ");
            (firstMatrix * secondMatrix).PrintMatrix();

            Console.WriteLine("Умножение матрицы на число : ");
            (firstMatrix * 3).PrintMatrix();

            Console.WriteLine("Транспорнированная матрица : ");
            firstMatrix.GetTranspose().PrintMatrix();

            Console.WriteLine($"Определитель первой матрицы = {firstMatrix.GetDeterminant()}");

            Console.Read();
        }
    }
}


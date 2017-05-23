using System;

namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пример : ");
            string example = Console.ReadLine();
            Console.Write("Ответ : ");
            Console.Write(MathParser.Example(example.ToCharArray()).ToString());

            //QuadraticAlgorithmExecutionTime q = new QuadraticAlgorithmExecutionTime();
            //q.LeadTime(2, 2);

            Console.Read();
        }
    }
}

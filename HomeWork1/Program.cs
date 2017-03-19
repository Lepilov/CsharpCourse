using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");

            Console.Write("Введите 1 число: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                Console.WriteLine("Наименьшее число: {0}", a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine("Наименьшее число: {0}", b);
            }
            else
            {
                Console.WriteLine("Наименьшее число: {0}", c);
            }

            Fibonacci(a);
            Fibonacci(b);
            Fibonacci(c);
            void Fibonacci(int n)
            {
                int r, r1 = 1, r2 = 0; 
                for (r = 1; ;r++)
                {
                    r = r1 + r2;
                    if (r >= n)
                        break;
                    r1 = r2;
                    r2 = r;
                    Console.Write("{0}  ", r);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

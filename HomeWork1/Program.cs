using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[3];

            for (int i = 0; i < n.Length; i++)
            {
                try
                {
                    Console.Write("Введите {0} число: ", i + 1);
                    n[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число!");
                    i--;
                }
            }

            int min = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < min)
                {
                    min = n[i];
                }
            }
            Console.WriteLine("Наименьшее число: {0}", min);

            Fib(n);
            void Fib(int[] array)
            {
                int value;
                for (int i = 0; i < array.Length; i++)
                {
                    value = array[i];
                    Fibonacci(value);
                }
            }


            void Fibonacci(int value)
            {
                int a = 1, b = 1;
                Console.Write(a + " " + b);
                int fib = 2, i = 2;
                while (i < value)
                {
                    fib = a + b;
                    a = b;
                    b = fib;
                    Console.Write(" " + fib);
                    i++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

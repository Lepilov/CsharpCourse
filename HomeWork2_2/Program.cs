using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<int> vectorA = new Vector<int>(1, 2);
            Vector<int> vectorB = new Vector<int>(1, 2);
            Console.WriteLine($"Ветрок А: {vectorA}");
            Console.WriteLine($"Вектор В: {vectorB}");
            Console.WriteLine($"Сумма векторов: {vectorA + vectorB}");
            Console.WriteLine($"Произведение векторов: {vectorA * 5}");
            Console.WriteLine("Массив векторов: ");
            var vectorGenerator = new VectorGenerator<int>(3);
            foreach (var item in vectorGenerator)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine($"Факториал стек: {FactStack(5)}");
            Console.WriteLine($"Факториал очереди: {FactQueue(10)}");
        }

        private static int FactStack(int n)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            for (int i = 2; i <= n; i++)
            {
                stack.Push(stack.Pop() * i);
            }
            return stack.Pop();
        }

        private static int FactQueue(int n)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for (int i = 2; i <= n; i++)
            {
                queue.Enqueue(queue.Dequeue() * i);
            }
            return queue.Dequeue();
        }
    }
}

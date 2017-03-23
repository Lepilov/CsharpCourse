using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        
        static void ArrayOfRandomNumbers(int[] array)
        {
            Random randomNumbers = new Random();

            for (int i = 0, n = array.Length; i < n; i++)
            {
                array[i] = randomNumbers.Next(-10, 10);
            }

            Console.Write("Массив случайных чисел : ");

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BubbleSort(array);
        }

        static void BubbleSort(int[] array)
        {
            Console.Write("Сортирует массив методом пузырька: ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Введите число : ");

            uint number;

            if (!(uint.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Ввели не число");
                Console.Read();
                return;
            }

            int[] array = new int[number];
            ArrayOfRandomNumbers(array);

            Console.Read();
        }
    }
}

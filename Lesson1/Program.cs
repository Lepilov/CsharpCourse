﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void PrintFibNumberLessThanNumber(uint number)
        {

            Console.Write("Числа Фибонначи меньше числа " + number.ToString() + ": ");

            uint firstFibNumber = 0;
            uint secondFibNumber = 1;

            if (number != 0)
            {
                Console.Write(firstFibNumber + " ");
            }

            while (secondFibNumber < number)
            {
                Console.Write(secondFibNumber + " ");
                uint nextSecondNumber = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = nextSecondNumber;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            uint number1, number2, number3;
            if (!Utils.TryEnterNumberFromConsole(out number1)|| 
                !Utils.TryEnterNumberFromConsole(out number2)|| 
                !Utils.TryEnterNumberFromConsole(out number3))
            {
                Console.Read();
                return;
            }

            uint minNumber = Math.Min(Math.Min(number1, number2), number3);

            Console.Write("Минимальное число: ");
            Console.WriteLine(minNumber);

            PrintFibNumberLessThanNumber(number1);
            PrintFibNumberLessThanNumber(number2);
            PrintFibNumberLessThanNumber(number3);
            
            Console.Read();
        }
    }
}

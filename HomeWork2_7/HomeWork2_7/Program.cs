using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fact(3);
            //Fact(4);

            //ReverseStr("one_two,_.three!");

            SumString();
        }

        public static void Fact(int n)
        {
            int temp = 1;
            int r = 1;
            for (int i = 2; i <= n; ++i)
            {
                r *= i;
                temp = r;
                temp *= r;
            }         
            Console.WriteLine(temp); 
        }

        public static void ReverseStr(string str)
        {
            string reverseStr = "";
            StringBuilder resultstr = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    reverseStr = str[i] + reverseStr;
                }
                else
                {
                    reverseStr += str[i];
                    resultstr.Append(reverseStr);
                    reverseStr = null;
                }
            }
            Console.WriteLine(resultstr.ToString());
        }

        public static void SumString()
        {
            Console.Write($"Введите первое число : ");
            string number1 = Console.ReadLine();

            Console.Write($"Введите второе число : ");
            string number2 = Console.ReadLine();

            Console.WriteLine($"Результат: {decimal.Parse(number1) + decimal.Parse(number2)}");
        }
    }
}

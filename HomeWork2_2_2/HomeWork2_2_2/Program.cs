using System;

namespace HomeWork2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пример : ");
            try
            {
                string example = Console.ReadLine();
                if (example == String.Empty)
                {
                    throw new FormatException();
                }
                else if (example == ".")
                {
                    throw new ArgumentException();
                }
                Console.Write("Ответ : ");
                Console.Write(MathParser.Example(example.ToCharArray()).ToString());
            }
            catch(FormatException)
            {
                Console.WriteLine("Пустая строка");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Недопустимый символ \".\"");
            }

            Console.Read();
        }
    }
}

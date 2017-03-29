using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : ");
            string enteredString = Console.ReadLine();

            StringHelper sHelper = new StringHelper(enteredString);
            //sHelper.inputString = enteredString;

            Console.WriteLine(sHelper.IsPolyndrome() ? "Является полиндромом" : "Не является полиндромом");
            Console.WriteLine($"Количество слов : {sHelper.GetCountWords()}");
            Console.WriteLine($"Перевернутая строка : {sHelper.GetInverseString()}");

            Console.Read();
        }
    }
}

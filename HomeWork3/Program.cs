using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку : ");
            string inputString = Console.ReadLine();

            Palindrome palindrome = new Palindrome(inputString);

            if (palindrome.isPalindrome() == true)
            {
                Console.WriteLine("Строка является палиндромом");
                Console.WriteLine("Количество слов в строке : {0}", palindrome.SumOfWordsInLine());
                Console.WriteLine("Перевернутая строка : {0}", palindrome.InvertedString());
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }

            Console.Read();
        }
    }

    class Palindrome
    {
        private string palindrome;

        public Palindrome(string palindrome)
        {
            this.palindrome = palindrome;
        }

        public bool isPalindrome()
        {
            string lineFirstText = this.palindrome.Replace(" ", "").ToLower();
            char[] arr = lineFirstText.ToCharArray();
            Array.Reverse(arr);
            string lineSecondText = new string(arr);
            if (lineFirstText == lineSecondText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SumOfWordsInLine()
        {
            string[] sumOfWordsInLine = this.palindrome.Split();
            return sumOfWordsInLine.Length;
        }

        public string InvertedString ()
        {
            char[] invertedString = this.palindrome.ToCharArray();
            Array.Reverse(invertedString);
            return new string(invertedString);
        }

    }
}

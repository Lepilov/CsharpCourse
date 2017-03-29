using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class StringHelper
    {
        private string inputString;

        public StringHelper(string inputString)
        {
            this.inputString = inputString;
        }

        //throw new NotImplementedException(); не реализован метод, код
        public bool IsPolyndrome()
        {
            if (inputString == null)
            {
                return false;
            }
            return inputString == GetInverseString();
        }

        public uint GetCountWords()
        {
            List<char> separators = new List<char>();
            foreach (char ch in inputString)
            {
                if (!char.IsLetterOrDigit(ch) && !separators.Contains(ch))
                {
                    separators.Add(ch);
                }
            }

            string[] words = inputString.Split(separators.ToArray());

            uint countWords = 0;
            foreach (string word in words)
            {
                //string.Empty проверка на пустату
                //IsNullOrEmpty проверка на пустоту строки
                if (!string.IsNullOrEmpty(word))
                {
                    countWords++;
                }
            }

            return countWords;
        }

        public string GetInverseString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result.Append(inputString[i]);
            }

            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one two free";
            string s2 = "two";
            string words = s1.Split(' ').OrderByDescending(x => x.Length).FirstOrDefault();
            Console.WriteLine(Array.FindIndex(s1.Split(' '), x => x.Equals(s2)));
        }
    }
}

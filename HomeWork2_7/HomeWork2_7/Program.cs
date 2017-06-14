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
            Fact(3);
            Fact(4);

            ReverseStr("one_two,_.three!");

            //var numstr1 = "11111111119";
            //var numstr2 = "1";
            //Console.WriteLine(BigNumber(numstr1, numstr2));
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

        //public static string BigNumber(string str1, string str2)
        //{
        //    StringBuilder resultstr = new StringBuilder();
        //    int residual = 0;
        //    string bigstr1, bigstr2;
        //    if (str1.Length >= str2.Length)
        //    {
        //        bigstr1 = str1;
        //        bigstr2 = str2;
        //    }
        //    else
        //    {
        //        bigstr1 = str2;
        //        bigstr2 = str1;
        //    }

        //    for (int i = bigstr1.Length - 1; i >= 0; i--)
        //    {
        //        for (int j = bigstr2.Length; j >= 0; j--)
        //        {
        //            int num1, num2;
        //            int.TryParse(str1[i].ToString(), out num1);
        //            int.TryParse(str2[j].ToString(), out num2);

        //            var bigSumNumbers = num1 + num2 + residual;
        //            residual = (int)bigSumNumbers / 10;
        //            resultstr.Append(bigSumNumbers % 10);
        //        }
        //    }
        //    return new string(resultstr.ToString().ToArray());
        //}
    }
}

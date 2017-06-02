using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2_2
{
    class MathParser
    {
        public static double Example(char[] exp)
        {
            return ParseSummands(exp, 0);
        }

        public static double ParseSummands(char[] exp, int index)
        {
            double x = ParseFactors(exp, ref index);
            while (true)
            {
                char operators = exp[index];
                if (operators != '+' && operators != '-')
                {
                    return x;
                }
                index++;
                double y = ParseFactors(exp, ref index);
                if (operators == '+')
                {
                    x += y;
                }
                else
                {
                    x -= y;
                }
            }
        }

        public static double ParseFactors(char[] exp, ref int index)
        {
            double x = GetDouble(exp, ref index);
            while (true)
            {
                char operators = exp[index];
                if (operators != '/' && operators != '*')
                {
                    return x;
                }
                index++;
                double y = GetDouble(exp, ref index);
                if (operators == '/' && y != 0)
                {
                    x /= y;
                }
                else if (operators == '*')
                {
                    x *= y;
                }
            }
        }

        public static double GetDouble(char[] exp, ref int index)
        {
            string str = "";
            while ((exp[index] >= 48 && exp[index] <= 57) || exp[index] == 46)
            {
                str += exp[index].ToString();
                index++;
                if (index == exp.Length)
                {
                    index--;
                    break;
                }
            }

            return double.Parse(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Parse("1990,04,15").Age();
            Console.WriteLine(date);

            var date2 = new DateTime(1945,5,9).Age();
            Console.WriteLine(date2);
            Console.WriteLine();

            List<DateTime> dateList = new List<DateTime>();
            dateList.Add(new DateTime(2001,5,20));
            dateList.Add(new DateTime(1945,5,9));
            foreach (var dates in dateList.DateString())
            {
                Console.WriteLine(dates);
            }
        }        
    }

    static class M
    {
        public static int Age(this DateTime date)
        {
            return DateTime.Today.Year - date.Year;
        }

        public static IEnumerable<string> DateString(this IEnumerable<DateTime> dates)
        {
            return dates.Select(date=>($"{date.Day}.{date.Month}.{date.Year}"));
        }
    }
}
    

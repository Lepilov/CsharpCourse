using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25App
{
    class Program
    {
        static void Main(string[] args)
        { 
            var doc = new DocumentContextDb();
            BM25 bm25 = new BM25(doc);
            Console.WriteLine($"Введите запрос: ");
            var query = Console.ReadLine();
            bm25.QueryWords(query);
            var score = doc.Documents.OrderByDescending(w => w.PValue);
            foreach (var temp in score)
            {
                Console.WriteLine($"Оценка {temp.Text} релевантности документа {temp.PValue}");
            }
        }
    }
}

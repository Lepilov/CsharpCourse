using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Bm25
    {
        public IEnumerable<Document> DocCollection { get; }

        private double k1 = 2.0;
        private double b = 0.75;
        /// <summary>
        /// средняя длина документа
        /// </summary>
        private double avgdl;

        public Bm25(IEnumerable<Document> docCollection)
        {
            DocCollection = docCollection;
            avgdl = DocCollection.Sum(doc => doc.Words.Count) / DocCollection.Count();
        }

        public IEnumerable<Document> RankDocsByQuery(string query)
        {
            // Получить слова запроса
            var queryWords = query.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var docsCnt = DocCollection.Count();
            // Высчитать idf для слов запроса
            var quWrdsIdfs = queryWords.Select(quWrd =>
            {
                var nWrd = DocCollection.Count(doc => doc.Words.Any(wrd => wrd.Text.Equals(quWrd, StringComparison.CurrentCultureIgnoreCase)));
                var idf = Math.Log10((docsCnt - nWrd + 0.5) / (nWrd + 0.5));
                return new { queryWrd = quWrd, queryWrdIdf = Math.Abs(idf)};
            });

            // Отранжировать документы
            var rankedDocs = DocCollection.Select(doc =>
            {
                var score = 0.0;
                foreach (var idfWrd in quWrdsIdfs)      // Проходя по словам запроса для каждого док-та
                {
                    Word wordInDoc;
                    // Выбрать из док-та слово, которое есть в запросе, и рассчитать для него score
                    if ((wordInDoc = doc.Words.FirstOrDefault(wrd => wrd.Text.Equals(idfWrd.queryWrd, StringComparison.CurrentCultureIgnoreCase))) != null)
                    {
                        score += idfWrd.queryWrdIdf * wordInDoc.TermFrequency * (k1 + 1)
                                 / (wordInDoc.TermFrequency + k1 * (1 - b + b * doc.Words.Count / avgdl));
                    }
                }
                return new { Doc = doc, Score = score };
            })
            .OrderByDescending(scoredDoc => scoredDoc.Score)    // Отсортировать документы по score
            .Where(scoredDoc => scoredDoc.Score > 0)
            .Select(scoredDoc => scoredDoc.Doc);

            return rankedDocs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25App
{
    class BM25
    {
        private DocumentContextDb documentContextDb;
        private double countDocumentsWord;
        private double score = 0.0;
        private double k = 2.0;
        private double b = 0.75;

        public BM25(DocumentContextDb documentContextDb)
        {
            this.documentContextDb = documentContextDb;
            CountDocumentsDB();
            Avgdl();
        }

        public void QueryWords(string querty)
        {
            var queryWords = querty.Split(' ');
            foreach (var temp in documentContextDb.Documents.Include(w => w.Words))
            {
                foreach (var value in queryWords)
                {
                    score += Score(temp, value);
                }

                temp.PValue = score;
            }
        }

        private double Score(Document document, string word)
        {
            double idf = Math.Log((CountDocumentsDB() - countDocumentsWord + 0.5) / (countDocumentsWord + 0.5));

            double result = TermFrequency(document, word) * (k + 1) / (TermFrequency(document, word) + k *
                (1 - b + b * (CountWordsDocument(document) / Avgdl())));

            score = idf * result;
            return score;
        }

        private double CountDocumentsDB()
        {
            double countDocumentsDB = documentContextDb.Documents.Count();
            return countDocumentsDB;
        }

        private double CountDocumentsWord(string word)
        {
            foreach (var temp in documentContextDb.Documents.Include(w => w.Words))
            {
                countDocumentsWord += temp.Words.Count(t => t.Name == word);
            }

            return countDocumentsWord;
        }

        private double CountWordsDocument(Document document)
        {
            double countWordsDocument = document.Words.Count;
            return countWordsDocument;
        }

        private double CountWordsInDocument(Document document, string word)
        {
            double countWordsInDocument = document.Words.Count(t => t.Name == word);
            return countWordsInDocument;
        }

        private double Avgdl()
        {
            double avgdl = 0.0;
            foreach (var temp in documentContextDb.Documents.Include(w => w.Words))
            {
                avgdl += temp.Words.Count;
            }

            return avgdl / CountDocumentsDB();
        }

        private double TermFrequency(Document document, string word)
        {
            double termFrequency = CountWordsInDocument(document, word) / CountWordsDocument(document);
            return termFrequency;
        }         
    }
}

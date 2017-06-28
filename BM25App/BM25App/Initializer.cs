using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25App
{
    class Initializer : DropCreateDatabaseAlways<DocumentContextDb>
    {
        protected override void Seed(DocumentContextDb context)
        {
            var word1 = new Word { Name = @"Не напрасно дули ветры, Не напрасно шла гроза" };
            var word2 = new Word { Name = @"Лениво дышит полдень мглистый, Лениво катится река. И в тверди пламенной и чистойЛениво тают облака" };

            context.Words.Add(word1);
            context.Words.Add(word2);

            var document1 = new Document()
            {
                Text = "Текст1",
                Words = new List<Word>() { word1, word2 }
            };
            context.Documents.Add(document1);

            var document2 = new Document()
            {
                Text = "Текст2",
                Words = new List<Word>() { word1, word2 }
            };
            context.Documents.Add(document2);
        }
    }
}

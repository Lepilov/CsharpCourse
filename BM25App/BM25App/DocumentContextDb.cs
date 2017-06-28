using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25App
{
    public class DocumentContextDb : DbContext
    {
        static DocumentContextDb()
        {
            Database.SetInitializer(new Initializer());
        }

        public IDbSet<Document> Documents { get; set; }

        public IDbSet<Word> Words { get; set; }
    }
}

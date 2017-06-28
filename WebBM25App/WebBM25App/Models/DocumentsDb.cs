using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class DocumentsDb : DbContext
    {
        public IDbSet<Document> Documents { get; set; }

        public IDbSet<Word> Words { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

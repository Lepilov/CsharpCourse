using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25App
{
    public class Word
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}

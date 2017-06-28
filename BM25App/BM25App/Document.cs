using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25App
{
    public class Document
    {
        public int Id { get; set; }

        public double PValue { get; set; }

        public string Text { get; set; }

        public virtual ICollection<Word> Words { get; set; }
    }
}

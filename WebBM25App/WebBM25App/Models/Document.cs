using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Document
    {
        public int Id { get; set; }

        [DisplayName("Поиск")]
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(100)]
        public string Text { get; set; }
        public virtual ICollection<Word> Words { get; set; }

        public Document(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Входной документ пустой!");

            Text = text;
            var punctuation = Text.Where(ch => char.IsControl(ch)
                                              || char.IsPunctuation(ch)
                                              || char.IsWhiteSpace(ch))
                                  .Distinct()
                                  .ToArray();
            var words = Text.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
            Words = words.Select(wrd => new Word(wrd, words.Count(smWrd => wrd == smWrd) / (double)words.Count())).ToArray();
        }

        public Document()
        {
            Text = string.Empty;
        }

        [DisplayName("Категория")]
        public int? CategoryId { get; set; }

        [DisplayName("Категория")]
        public Category Category { get; set; }
    }
}

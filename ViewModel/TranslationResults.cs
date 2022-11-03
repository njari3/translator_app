using System;
using System.Collections.Generic;
using Translator_app.Model;

namespace Translator_app.ViewModel
{
    public class TranslationResults
    {
        public int Id { get; set; }
        public string OriginalWord { get; set; }
        public int OriginalWordId { get; set; }
        public List<TranlatedWords> TranlatedWords { get; set; }
        public TranslationResults(Word word)
        {
            if (word is null)
                throw new ArgumentNullException(nameof(word));

            Id = word.Id;
            OriginalWord = word.Text;
            OriginalWordId = word.TextId;
            TranlatedWords = new List<TranlatedWords>();
        }
        public TranslationResults()
        {

        }
    }

}

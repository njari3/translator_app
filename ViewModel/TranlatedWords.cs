using System;
using Translator_app.Model;

namespace Translator_app.ViewModel
{
    public class TranlatedWords
    {
        public int Id { get; set; }
        public string TranslatedWord { get; set; }
        public int TranslatedWordId { get; set; }

        public TranlatedWords(int id, string translatedWord, int translatedWordId)
        {
            Id = id;
            TranslatedWord = translatedWord ?? throw new ArgumentNullException(nameof(translatedWord));
            TranslatedWordId = translatedWordId;
        }
        public TranlatedWords(Word word)
        {
            Id = word.Id;
            TranslatedWord = word.Text;
            TranslatedWordId = word.TextId;
        }
        public TranlatedWords()
        {

        }
    }

}

using System.Collections.Generic;
using Translator_app.Model;
using Translator_app.ViewModel;

namespace Translator_app.Services
{
    public interface ITranslatorServices
    {
        public IEnumerable<Language> GetAllLanguage();
        public IEnumerable<TranslationResults> GroupedTranslateWord(SearchingParameter searchingParameter);

    }
}

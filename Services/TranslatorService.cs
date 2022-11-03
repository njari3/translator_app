using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator_app.Model;
using Translator_app.Services.DataReader;
using Translator_app.ViewModel;

namespace Translator_app.Services
{
    public class TranslatorService : ITranslatorServices
    {
        private readonly ILogger _logger;
        private readonly IDbReader _dbReader;
        private readonly List<TranslationResults> _translationResultsList = new List<TranslationResults>();
        public TranslatorService(ILogger<TranslatorService> logger, IDbReader dbReader)
        {
            _logger = logger;
            _dbReader = dbReader;
        }
        public IEnumerable<Language> GetAllLanguage() =>
             _dbReader.GetAllLanguage();

        public IEnumerable<TranslationResults> GroupedTranslateWord(SearchingParameter searchingParameter)
        {
            var textIds = _dbReader.WordDb()
                .Where(c => c.LanguageId == searchingParameter.LanguageFromId)
                .Where(c => c.Text.ToLower().StartsWith(searchingParameter.Text))
                .Select(c => c.TextId);

            var words = _dbReader.WordDb()
                .Where(c => (c.LanguageId == searchingParameter.LanguageToId || c.LanguageId == searchingParameter.LanguageFromId) && textIds.Contains(c.TextId)).
                GroupBy(c => c.TextId).ToList();

            foreach (var item in words)
            {
                var originalWord = item.Where(c => c.LanguageId == searchingParameter.LanguageFromId).First();
                var _translationResults = new TranslationResults(originalWord);

                foreach (var items in item.Where(c => c.LanguageId != searchingParameter.LanguageFromId))
                {
                    _translationResults.TranlatedWords.Add(new TranlatedWords(items));
                }

                _translationResultsList.Add(_translationResults);
            }
            _logger.LogInformation($"Sucessful collected {_translationResultsList.Count} list of data");
            return _translationResultsList;
        }
    }

}

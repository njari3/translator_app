using System;

namespace Translator_app.ViewModel
{
    public class SearchingParameter
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                if (value == null)
                    _text = "";
                else
                    _text = value.ToLower().Trim();
            }
        }
        public string LanguageFromId { get; set; }
        public string LanguageToId { get; set; }

        public SearchingParameter(string text, string languageFromId, string languageToId)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            LanguageFromId = languageFromId ?? throw new ArgumentNullException(nameof(languageFromId));
            LanguageToId = languageToId ?? throw new ArgumentNullException(nameof(languageToId));
        }
    }
}

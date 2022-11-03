using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator_app.Model;

namespace Translator_app.Services.DataReader
{
    public interface IDbReader
    {
        IEnumerable<Language> GetAllLanguage();
        IEnumerable<Word> WordDb();
    }
}
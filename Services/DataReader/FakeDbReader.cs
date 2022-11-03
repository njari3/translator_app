using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translator_app.Model;

namespace Translator_app.Services.DataReader
{
    public class FakeDbReader : IDbReader
    {
        public IEnumerable<Language> GetAllLanguage()
        {
            return new List<Language> {
            new Language(){Id ="EN" , Name ="English"},
            new Language(){Id ="HU" , Name ="Hungarian"}
            };
        }
        public IEnumerable<Word> WordDb()
        {
            return new List<Word>()
            {
                new Word{Id=0,Language=new Language(){Id ="EN" , Name ="English"},TextId=0,Text= "Account Holder Name",LanguageId="EN"},
                new Word{Id=1,Language= new Language(){Id ="HU" , Name ="Hungarian"},TextId=0,Text= "Számlatulajdonos neve",LanguageId="HU"},
                new Word{Id=2,Language=new Language(){Id ="EN" , Name ="English"},TextId=1,Text= "Active",LanguageId="EN"},
                new Word{Id=3,Language=new Language(){Id ="HU" , Name ="Hungarian"},TextId=1,Text= "Aktív",LanguageId="HU"},
            };
        }
    }
}

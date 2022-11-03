using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Translator_app.Model;

namespace Translator_app.Services.DataReader
{
    public class DbReader : IDbReader
    {
        public IEnumerable<Language> GetAllLanguage()
        {
            using (var dbContext = new MyDbContext())
            {
                var report = dbContext.Language.ToList();
                return report;
            };
        }
        public IEnumerable<Word> WordDb()
        {
            using (var dbContext = new MyDbContext())
            {
                var report = dbContext.Word.Include(c => c.Language).AsNoTracking().ToList();
                return report;
            };
        }
    }
}

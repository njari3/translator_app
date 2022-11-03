using Microsoft.EntityFrameworkCore;
using Translator_app.Model;

namespace Translator_app
{
    public class MyDbContext : DbContext
    {
        public DbSet<Word> Word { get; set; }
        public DbSet<Language> Language { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-ONEVN52;initial catalog=TranslatorDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one to many
            modelBuilder.Entity<Word>()
                    .HasOne(s => s.Language)
                    .WithMany(g => g.Words)
                    .HasForeignKey(s => s.LanguageId);

        }
    }
}

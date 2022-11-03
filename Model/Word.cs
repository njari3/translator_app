using System.ComponentModel.DataAnnotations;

namespace Translator_app.Model
{
    public class Word
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TextId { get; set; }
        public string Text { get; set; }
        [Required]
        public Language Language { get; set; }
        public string LanguageId { get; set; }
    }
}

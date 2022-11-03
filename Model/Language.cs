using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Translator_app.Model
{
    public class Language
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Word> Words { get; set; }
    }
}

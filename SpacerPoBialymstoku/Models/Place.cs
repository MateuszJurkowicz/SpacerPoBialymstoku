using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SpacerPoBialymstoku.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string OldImageData { get; set; }
        public string ActualImageData { get; set; }
        public int Rating { get; set; }
        [NotMapped]
        public IFormFile OldImageFile { get; set; }
        [NotMapped] 
        public IFormFile ActualImageFile { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Place>(this);

    }
}

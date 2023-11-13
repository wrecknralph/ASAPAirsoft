using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASAPAirsoft.Models
{
    public class AirsoftGearModel
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName("Type (head, body, legs, hands, feet): ")]
        public string Type { get; set; }
        public string? Link { get; set; }
    }
}

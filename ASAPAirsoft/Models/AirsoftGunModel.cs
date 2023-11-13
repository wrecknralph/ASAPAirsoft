using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASAPAirsoft.Models
{
    public class AirsoftGunModel
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName("Type (battery, pump, compressed air):")]
        public string Type { get; set; }        
        public string? Link { get; set; }
    }
}

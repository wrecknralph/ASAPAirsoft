using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASAPAirsoft.Models
{
    public class AirsoftLocationModel
    {
        public Guid ID { get; set; }
        [Required]        
        public string Name { get; set; }
        [Required]        
        public string Description { get; set; }
        [Required]        
        public string Rules { get; set; }
        [Required]        
        public string City { get; set; }
        [Required]        
        public string Country { get; set; }
        [Required]        
        public string Address { get; set; }
    }
}

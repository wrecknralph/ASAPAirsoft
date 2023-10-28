using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftGunType
    {
        public AirsoftGunType()
        {
            AirsoftGunsOwneds = new HashSet<AirsoftGunsOwned>();
        }

        public int AirsoftGunTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AirsoftGunsOwned> AirsoftGunsOwneds { get; set; }
    }
}

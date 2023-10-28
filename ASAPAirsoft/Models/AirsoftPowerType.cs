using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftPowerType
    {
        public AirsoftPowerType()
        {
            AirsoftGunsOwneds = new HashSet<AirsoftGunsOwned>();
        }

        public int PowerTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AirsoftGunsOwned> AirsoftGunsOwneds { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftGearType
    {
        public AirsoftGearType()
        {
            AirsoftGears = new HashSet<AirsoftGear>();
        }

        public int GearTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AirsoftGear> AirsoftGears { get; set; }
    }
}

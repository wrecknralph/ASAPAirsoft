using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftFp
    {
        public AirsoftFp()
        {
            AirsoftAmmoTypes = new HashSet<AirsoftAmmoType>();
            AirsoftGunsOwneds = new HashSet<AirsoftGunsOwned>();
        }

        public int Fpsid { get; set; }
        public int? FpsStrength { get; set; }

        public virtual ICollection<AirsoftAmmoType> AirsoftAmmoTypes { get; set; }
        public virtual ICollection<AirsoftGunsOwned> AirsoftGunsOwneds { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftAmmoType
    {
        public AirsoftAmmoType()
        {
            AirsoftGunsOwneds = new HashSet<AirsoftGunsOwned>();
        }

        public int AmmoTypeId { get; set; }
        public string? Name { get; set; }
        public int? Size { get; set; }
        public int? Weight { get; set; }
        public int? AmmoMaterialId { get; set; }
        public int? FpsRated { get; set; }
        public int? Fpsid { get; set; }

        public virtual AirsoftAmmoMaterial? AmmoMaterial { get; set; }
        public virtual AirsoftFp? Fps { get; set; }
        public virtual ICollection<AirsoftGunsOwned> AirsoftGunsOwneds { get; set; }
    }
}

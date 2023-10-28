using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftGunsOwned
    {
        public int AirsoftGunsOwnedId { get; set; }
        public string? Name { get; set; }
        public int? AirsoftGunTypeId { get; set; }
        public int? Fpsid { get; set; }
        public int? AmmoTypeId { get; set; }
        public int? PowerTypeId { get; set; }

        public virtual AirsoftGunType? AirsoftGunType { get; set; }
        public virtual AirsoftAmmoType? AmmoType { get; set; }
        public virtual AirsoftFp? Fps { get; set; }
        public virtual AirsoftPowerType? PowerType { get; set; }
    }
}

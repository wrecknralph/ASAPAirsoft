using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftLocationAndRule
    {
        public int LocationRulesId { get; set; }
        public int? RulesId { get; set; }
        public int? LocationId { get; set; }

        public virtual AirsoftLocation? Location { get; set; }
        public virtual AirsoftLocationRule? Rules { get; set; }
    }
}

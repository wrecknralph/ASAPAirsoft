using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftLocationRule
    {
        public AirsoftLocationRule()
        {
            AirsoftLocationAndRules = new HashSet<AirsoftLocationAndRule>();
        }

        public int RulesId { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<AirsoftLocationAndRule> AirsoftLocationAndRules { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftGroupType
    {
        public AirsoftGroupType()
        {
            AirsoftGroups = new HashSet<AirsoftGroup>();
        }

        public int GroupTypeId { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<AirsoftGroup> AirsoftGroups { get; set; }
    }
}

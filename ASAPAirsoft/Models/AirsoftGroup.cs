using System;
using System.Collections.Generic;

namespace ASAPAirsoft.Models
{
    public partial class AirsoftGroup
    {
        public int GroupId { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Size { get; set; }
        public int? GroupTypeId { get; set; }

        public virtual AirsoftGroupType? GroupType { get; set; }
    }
}

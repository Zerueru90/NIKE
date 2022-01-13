using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Model
{
    public partial class Entry
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long LocationId { get; set; }
        public long? Rating { get; set; }
        public string Description { get; set; }
        public long? Likes { get; set; }
    }
}

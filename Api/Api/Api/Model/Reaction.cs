using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Model
{
    public partial class Reaction
    {
        public long Id { get; set; }
        public long? EntryId { get; set; }
        public long? UserId { get; set; }
        public long? LikeDislike { get; set; }
    }
}

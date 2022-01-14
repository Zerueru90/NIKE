using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Api.Model
{
    public partial class Reaction
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long? EntryId { get; set; }
        [Required]
        public long? UserId { get; set; }
        [Required]
        public long? LikeDislike { get; set; }
    }
}

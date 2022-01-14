using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Api.Model
{
    public partial class Entry
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public long LocationId { get; set; }
        [Required]
        public long? Rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public long? Likes { get; set; }
    }
}

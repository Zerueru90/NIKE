using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Api.Model
{
    public partial class RefreshToken
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public string JwtId { get; set; }
        [Required]
        public string CreationDate { get; set; }
        [Required]
        public string ExpiryDate { get; set; }
        [Required]
        public long? Used { get; set; }
        [Required]
        public long? UserId { get; set; }
    }
}

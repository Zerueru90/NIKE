using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Model
{
    public partial class RefreshToken
    {
        public long Id { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public string CreationDate { get; set; }
        public string ExpiryDate { get; set; }
        public long? Used { get; set; }
        public long? UserId { get; set; }
    }
}

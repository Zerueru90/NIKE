using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Api.Model
{
    public partial class Country
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

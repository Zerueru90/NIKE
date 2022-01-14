using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Api.Model
{
    public partial class City
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long? CountryId { get; set; }

        public virtual ICollection<Location> Poi { get; set; }

        public City()
        {
            Poi = new HashSet<Location>();
        }
    }
}

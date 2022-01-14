using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Api.Model
{
    public partial class POI
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long Longitude { get; set; }
        [Required]
        public long Latitude { get; set; }
        [Required]
        public long CityID { get; set; }

        public virtual City City {  get; set; }


    }
}

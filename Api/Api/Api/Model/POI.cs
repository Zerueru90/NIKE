using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

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
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public long CityID { get; set; }

        public virtual City City {  get; set; }
    }

    public class POIDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}

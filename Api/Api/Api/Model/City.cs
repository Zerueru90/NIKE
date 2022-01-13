using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Model
{
    public partial class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? CountryId { get; set; }
    }
}

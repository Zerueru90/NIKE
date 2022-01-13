using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Model
{
    public partial class Location
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long YCordinate { get; set; }
        public long XCordinate { get; set; }
    }
}

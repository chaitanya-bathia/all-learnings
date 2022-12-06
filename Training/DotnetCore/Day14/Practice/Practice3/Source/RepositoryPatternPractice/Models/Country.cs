using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternPractice.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }
    }
}

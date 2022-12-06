using System;
using System.Collections.Generic;

#nullable disable

namespace Day14Practice2.Models
{
    public partial class ManufacturePlant
    {
        public ManufacturePlant()
        {
            PlantWiseToyManufactures = new HashSet<PlantWiseToyManufacture>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string Location { get; set; }
        public string Pincode { get; set; }

        public virtual ICollection<PlantWiseToyManufacture> PlantWiseToyManufactures { get; set; }
    }
}

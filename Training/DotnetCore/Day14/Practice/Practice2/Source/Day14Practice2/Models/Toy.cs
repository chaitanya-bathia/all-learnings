using System;
using System.Collections.Generic;

#nullable disable

namespace Day14Practice2.Models
{
    public partial class Toy
    {
        public Toy()
        {
            OrderItems = new HashSet<OrderItem>();
            PlantWiseToyManufactures = new HashSet<PlantWiseToyManufacture>();
        }

        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<PlantWiseToyManufacture> PlantWiseToyManufactures { get; set; }
    }
}

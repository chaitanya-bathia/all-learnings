using System;
using System.Collections.Generic;

#nullable disable

namespace Day14Practice2.Models
{
    public partial class Address
    {
        public Address()
        {
            Orders = new HashSet<Order>();
        }

        public int AddressId { get; set; }
        public int? CustomerId { get; set; }
        public string Address1 { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

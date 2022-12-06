using System;
using System.Collections.Generic;

#nullable disable

namespace Day14Practice2.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public bool? Prepaid { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Address { get; set; }
        public decimal? Total { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

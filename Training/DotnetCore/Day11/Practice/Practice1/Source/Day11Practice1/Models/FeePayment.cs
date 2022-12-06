using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class FeePayment
    {
        public int? StudentId { get; set; }
        public int? AmountPaid { get; set; }
        public DateTime? DateOfPayment { get; set; }

        public virtual Student Student { get; set; }
    }
}

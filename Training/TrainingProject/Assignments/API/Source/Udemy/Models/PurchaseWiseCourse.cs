using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class PurchaseWiseCourse
    {
        public int ListingId { get; set; }
        public int PurchaseId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}

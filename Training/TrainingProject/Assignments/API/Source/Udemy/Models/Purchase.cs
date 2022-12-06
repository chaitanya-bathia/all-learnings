using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseWiseCourses = new HashSet<PurchaseWiseCourse>();
        }

        public int PurchaseId { get; set; }
        public int? UserId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? Total { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<PurchaseWiseCourse> PurchaseWiseCourses { get; set; }
    }
}

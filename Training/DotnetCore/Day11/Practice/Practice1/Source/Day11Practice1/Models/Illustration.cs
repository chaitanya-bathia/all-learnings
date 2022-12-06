using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class Illustration
    {
        public Illustration()
        {
            ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        }

        public int IllustrationId { get; set; }
        public string Diagram { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
    }
}

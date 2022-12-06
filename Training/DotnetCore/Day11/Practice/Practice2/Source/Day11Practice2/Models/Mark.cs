using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice2.Models
{
    public partial class Mark
    {
        public int? StudentId { get; set; }
        public int? Science { get; set; }
        public int? Math { get; set; }
        public int? English { get; set; }
        public decimal? Average { get; set; }
        public string Grade { get; set; }

        public virtual Student Student { get; set; }
    }
}

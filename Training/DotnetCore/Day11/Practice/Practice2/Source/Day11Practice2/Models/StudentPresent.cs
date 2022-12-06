using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice2.Models
{
    public partial class StudentPresent
    {
        public int StudentPresentId { get; set; }
        public int? StudentId { get; set; }
        public int? Month { get; set; }
        public int? Present { get; set; }

        public virtual Student1 Student { get; set; }
    }
}

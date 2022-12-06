using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class CourseEnrolled
    {
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}

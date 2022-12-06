using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice2.Models
{
    public partial class StudentDetail
    {
        public int StudentDetailId { get; set; }
        public int? StudentId { get; set; }
        public int? Standard { get; set; }
        public string Gender { get; set; }

        public virtual Student1 Student { get; set; }
    }
}

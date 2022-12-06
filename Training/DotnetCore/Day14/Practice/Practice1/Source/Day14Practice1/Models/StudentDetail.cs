using System;
using System.Collections.Generic;

#nullable disable

namespace Day14Practice1.Models
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

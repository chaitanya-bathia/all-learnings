using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? TotalFees { get; set; }
        public int? RemainingAmt { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Day14Practice1.Models
{
    public partial class JobHistory
    {
        public int EmployeeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? JobId { get; set; }
        public int? DepartmentId { get; set; }
        public string Location { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class MyEmployee
    {
        public short EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public short DeptId { get; set; }
        public short? ManagerId { get; set; }
    }
}

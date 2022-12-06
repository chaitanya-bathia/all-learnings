using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternPractice.Models
{
    public partial class NewEmployee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Salary { get; set; }
    }
}

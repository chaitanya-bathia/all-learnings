using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Day11Practice2.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? HireDate { get; set; }
        public int JobId { get; set; }
        public int Salary { get; set; }
        public decimal Commission { get; set; }
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public string DateOfBirth { get; set; }
        public int? Age { get; set; }

        public virtual Department Department { get; set; }
        public virtual Job Job { get; set; }
    }
    public class EmployeeDTO
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day7Practice2
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Deparment { get; set; }

        public override string ToString()
        {
            return ($"EmployeeID: \t{ID}\nEmployee Name: \t{FirstName} {LastName}\nSalary: \t{Salary}\nJoining Date: \t{JoiningDate.ToShortDateString()}\nDepartment: \t{Deparment}");
        }
    }
}

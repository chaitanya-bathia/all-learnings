using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Assignment1
{
    class PartTime : Employee
    {
        public int NumberOfHours=0, SalaryPerHour=0;
        public override void Get()
        {
            base.Get();

            Console.WriteLine("Enter Number Of Hours Worked: ");
            NumberOfHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Salary Per Hour: ");
            SalaryPerHour = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"{Name}, {Address}, Number of Hours: {NumberOfHours}, Salary Per Hour: {SalaryPerHour}, Total Salary : {Salary()}");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public override decimal Salary()
        {
            return NumberOfHours * SalaryPerHour;
        }
    }
}

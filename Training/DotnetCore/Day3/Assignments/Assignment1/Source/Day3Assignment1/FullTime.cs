using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Assignment1
{
    class FullTime : Employee
    {
        public decimal Basic=0, HRA = 0, TA = 0, DA = 0;

        public override void Get()
        {
            base.Get();

            Console.WriteLine("Enter Basic:");
            Basic = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter HRA:");
            HRA = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter TA:");
            TA = Convert.ToDecimal(Console.ReadLine()); //Usually around 5% of Salary

            Console.WriteLine("Enter DA:");
            DA = Convert.ToDecimal(Console.ReadLine()); //Usually around 3% of Salary
        }

        public override void Display()
        {
            Console.WriteLine($"{Name}, {Address}, Basic Salary:{Basic}, Total Salary:{Salary()}");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public override decimal Salary()
        {
            return Basic + HRA + TA + DA;
        }
    }
}

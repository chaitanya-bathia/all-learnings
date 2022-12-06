using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Assignment1
{
    abstract class Employee : Emp
    {
        public int ID;
        public string Name, Address, PANNumber;
        public Employee()
        {
        }
        public virtual void Get()
        {
            Console.WriteLine("Enter EmployeeID:");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            Address = Console.ReadLine();

            Console.WriteLine("Enter PAN Number:");
            PANNumber = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee Details Are\nID: {ID},\nName: {Name},\nAddress: {Address},\nPAN Number: {PANNumber}, Salary : {Salary()}");
        }


        public abstract decimal Salary();
        
    }
}

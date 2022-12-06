using System;

namespace Day11Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DataHelper dh = new DataHelper();
            //foreach (var item in dh.getEmployees())
            //{
            //    Console.WriteLine($"ID: {item.EmpID},  Name: {item.EmpName}");
            //}
            dh.getEmployeesWithDept();
            Console.WriteLine("Enter an EmployeeID to search:");
            int empID = Convert.ToInt32(Console.ReadLine());
            dh.GetEmployeeByID(empID);

            //dh.insertEmployee();

            //dh.addDepartment();
        }
    }
}

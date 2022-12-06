using Day11Practice2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Day11Practice2
{
    class DataHelper
    {
        private TestDBContext context;
        public DataHelper()
        {
            context = new TestDBContext();
        }

        public List<Emp> getEmployees()
        {
            List<Emp> listEmp = new List<Emp>();

            listEmp =  context.Employees.Select(emp => new Emp{EmpID = emp.EmployeeId, EmpName = emp.FirstName}).ToList();
            //List<Emp> list = context.Employees.Select(a => { } ).ToList();
            
            return listEmp;
        }

        public void getEmployeesWithDept()
        {

            var result = context.EmployeeDTO.FromSqlRaw<EmployeeDTO>("exec usp_getEmployeesWithDepartment").ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.EmployeeId}, {item.FirstName} {item.DepartmentId}, {item.DepartmentName}");
            } ;
        }

        //For the below function, cannot check for empty object when returning query from DB

        public void GetEmployeeByID(int EmployeeID)
        {
            //var newEmp = context.EmployeeDTO.FromSqlRaw<EmployeeDTO>("exec usp_getEmployeesWithDepartment").Where(emp => emp.EmployeeId == EmployeeID).ToList();

            //foreach (var item in newEmp)
            //{
            //    Console.WriteLine($"ID:{item.EmployeeId}, \tName:{item.FirstName}, \tDepartment Name: {item.DepartmentName}");
            //}

            var newEmp = context.Employees.FromSqlRaw<Employee>($"exec uspGetEmployeeByID {EmployeeID}").AsEnumerable();


            if (newEmp.Any())
            {
                foreach (var item in newEmp)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
            else
            {
                Console.WriteLine("Employee with this EmployeeCode Does not exist.");
            }
        }


        public void insertEmployee()
        {
            Employee emp = new Employee();
            
            Console.WriteLine("Enter EmployeeID:");
            emp.EmployeeId =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter First Name:");
            emp.FirstName = Console.ReadLine();
            
            Console.WriteLine("Enter Last Name:");
            emp.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            emp.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Job ID:");
            emp.JobId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Commission:");
            emp.Commission = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Manager ID:");
            emp.ManagerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department ID:");
            emp.DepartmentId = Convert.ToInt32(Console.ReadLine());

            context.Employees.Add(emp);

            context.SaveChanges();

            Console.WriteLine("Data Inserted into Database.");
        }

        public void addDepartment()
        {
            Department newDep = new Department();

            Console.WriteLine("Enter Department ID:");
            newDep.DepartmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department Name:");
            newDep.DepartmentName = Console.ReadLine();

            Employee emp = new Employee();

            Console.WriteLine("Enter EmployeeID:");
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Name:");
            emp.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            emp.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            emp.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Job ID:");
            emp.JobId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Commission:");
            emp.Commission = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Manager ID:");
            emp.ManagerId = Convert.ToInt32(Console.ReadLine());

            newDep.Employees.Add(emp);

            context.Add(newDep);

            context.SaveChanges();
        }
    }
}

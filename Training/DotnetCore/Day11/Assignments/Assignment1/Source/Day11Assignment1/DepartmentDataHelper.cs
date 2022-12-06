using Day11Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day11Assignment1
{
    class DepartmentDataHelper
    {
        private HospitalDBContext DbContext;
        public DepartmentDataHelper()
        {
            DbContext = new HospitalDBContext();
        }

        public List<Department> getAllDepartments()
        {
            List<Department> departmentList = DbContext.Departments.FromSqlRaw<Department>("SELECT * FROM DEPARTMENT").ToList();

            return departmentList;
        }

        public void addDepartment()
        {
            Department dept = new Department();

            Console.WriteLine("Enter Name of the Department to be added:");
            dept.DepartmentName = Console.ReadLine();

            Console.WriteLine("Do you want to add new Doctor for this Department?\nPress Y to enter new Doctor:");
            String choice = Console.ReadLine();

            if (choice == "Y" || choice == "y")
            {
                Program.smallBreaker();
                Console.WriteLine("Adding Doctor to new Department:");
                Program.smallBreaker();

                Doctor doctor = new Doctor();

                Console.WriteLine("Enter FirstName of Doctor:");
                doctor.FirstName = Console.ReadLine();

                Console.WriteLine("Enter LastName of Doctor:");
                doctor.LastName = Console.ReadLine();

                Console.WriteLine("Enter Qualification of Doctor:");
                doctor.Qualification = Console.ReadLine();

                Console.WriteLine("Enter Experience of Doctor:");
                doctor.Experience = Convert.ToInt32(Console.ReadLine());

                dept.Doctors.Add(doctor);
                Console.WriteLine("New Doctor added for the Department.");
            }


            DbContext.Add(dept);

            DbContext.SaveChanges();
            Console.WriteLine("New Department Added.");
        }
    }
}

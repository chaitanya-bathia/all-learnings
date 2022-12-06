using Day11Assignment1.Models;
using System;
using System.Collections.Generic;

namespace Day11Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Breaker();
            Console.WriteLine("Department");
            Breaker();
            smallBreaker();
            Console.WriteLine("Selecting All Departments:");
            smallBreaker();
            DepartmentDataHelper deptDH = new DepartmentDataHelper();

            List<Department> deptList = deptDH.getAllDepartments();

            foreach (var item in deptList)
            {
                Console.WriteLine($"DepartmentID: {item.DepartmentId}\t Department Name: {item.DepartmentName}");
            }

            //smallBreaker();
            //Console.WriteLine("Adding new Department");
            //smallBreaker();

            //deptDH.addDepartment();



            Breaker();
            Console.WriteLine("Doctor");
            Breaker();
            smallBreaker();
            Console.WriteLine("Selecting All Doctors:");
            smallBreaker();

            DoctorDataHelper DoctorDH = new DoctorDataHelper();

            List<Doctor> doctorList = DoctorDH.GetDoctors();

            foreach (var item in doctorList)
            {
                Console.WriteLine($"Doctor ID: { item.DoctorId}, Doctor Name: {item.FirstName} {item.LastName}, Qualification: {item.Qualification}, Joining Date: {item.JoiningDate}");
            }

            //Adding a new Doctor
            //smallBreaker();
            //Console.WriteLine("Adding new Doctor");
            //smallBreaker();

            //DoctorDH.AddDoctor();


            //deleting an existing Doctor
            //smallBreaker();
            //Console.WriteLine("Deleting Doctor");
            //smallBreaker();

            //DoctorDH.deleteDoctor();


            smallBreaker();
            Console.WriteLine("Updating Doctor");
            smallBreaker();

            DoctorDH.updateDoctor();

            smallBreaker();
            Console.WriteLine("Getting Doctor-Wise Patients:");
            smallBreaker(); 
            
            
            DoctorDH.getDoctorWisePatients();
            
            smallBreaker();
            Console.WriteLine("Getting Medicine Prescription for Patient:");
            smallBreaker();

            DoctorDH.getPrescription();

        }

        public static void Breaker()
        {
            Console.WriteLine("======================================================================================");
        }

        public static void smallBreaker()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

    }
}

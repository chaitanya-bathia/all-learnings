using Day11Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day11Assignment1
{
    class DoctorDataHelper
    {
        private HospitalDBContext DbContext;

        public DoctorDataHelper()
        {
            DbContext = new HospitalDBContext();
        }

        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctorList = DbContext.Doctors.FromSqlRaw<Doctor>("SELECT * FROM DOCTOR").ToList();

            return doctorList;
        }

        public void AddDoctor()
        {
            Doctor doctor = new Doctor();

            Console.WriteLine("Enter FirstName of Doctor:");
            doctor.FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName of Doctor:");
            doctor.LastName = Console.ReadLine();

            Console.WriteLine("Enter Qualification of Doctor:");
            doctor.Qualification = Console.ReadLine();

            Console.WriteLine("Enter Experience of Doctor:");
            doctor.Experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert Doctor's Department:");
            doctor.DepartmentId = Convert.ToInt32(Console.ReadLine());


            DbContext.Add(doctor);
            DbContext.SaveChanges();

            Console.WriteLine("Doctor Added.");
        }

        public void updateDoctor()
        {
            Console.WriteLine("Enter ID of the Doctor to be Updated:");
            int doctorID = Convert.ToInt32(Console.ReadLine());
            Doctor doctor = DbContext.Doctors.Where(x => x.DoctorId == doctorID).FirstOrDefault();

            doctor.Qualification = "MD";
            DbContext.Update(doctor);

            DbContext.SaveChanges();
            Console.WriteLine("Updated doctor info.");
        }

        public void deleteDoctor()
        {
            Console.WriteLine("Enter ID of the Doctor to be deleted:");
            int doctorID = Convert.ToInt32(Console.ReadLine());

            //DbContext.Doctors.FromSqlRaw<Doctor>($"DELETE FROM DOCTOR WHERE DoctorID = {doctorID}");

            Doctor doc = DbContext.Doctors.Where(doc => doc.DoctorId == doctorID).FirstOrDefault();

            DbContext.Doctors.Remove(doc);
            DbContext.SaveChanges();
            Console.WriteLine("Doctor Record Deleted.");

        }

        public void getDoctorWisePatients()
        {
            Console.WriteLine("Enter ID of the Doctor whose patients you want to find:");
            int doctorID = Convert.ToInt32(Console.ReadLine());

            Doctor doc = new Doctor();
            doc.Patients = DbContext.Patients.FromSqlRaw<Patient>($"SELECT * FROM PATIENT WHERE DoctorID = {doctorID}").ToList();

            if (doc.Patients.Count == 0)
            {
                Console.WriteLine("This doctor currently has no Patients.");
            }
            else
            {
                foreach (var item in doc.Patients)
                {
                    Console.WriteLine($"Patient ID: {item.PatientId}, Name: {item.FirstName} {item.LastName}, Doctor: {item.DoctorId}");
                }
            }
            
        }

        public void getPrescription()
        {
            Console.WriteLine("Enter Patient ID whose prescription is wanted:");
            int patientId = Convert.ToInt32(Console.ReadLine());

            var prescriptionDTO = DbContext.PrescriptionDTOs.FromSqlRaw($"exec uspGetPrescription {patientId}");

            foreach (var item in prescriptionDTO)
            {
                Console.WriteLine($"Patient ID: {item.PatientId}, \tPatient Name: {item.FirstName} {item.LastName}, \tMedicine: {item.DrugName}, \tMorning: {item.Morning},\tAfternoon: {item.Afternoon}\tNight: {item.Night}");
            }
        }
    }
}

using Day17Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Assignment.Controllers
{
    public class DoctorDataHelper
    {
        public HospitalDBContext dbcontext;

        public DoctorDataHelper()
        {
            dbcontext = new HospitalDBContext();
        }

        //Get All Doctors
        public async Task<List<Doctor>> GetDoctors()
        {
            List<Doctor> doctors = await dbcontext.Doctors.Select(x => x).ToListAsync();
            return doctors;
        }
        
        
        //Get Doctor by ID
        public async Task<Doctor> GetDoctorByID(int id)
        {
            Doctor doctor = await dbcontext.Doctors.Where(x => x.DoctorId == id).FirstAsync();
            return doctor;
        }


        //Post new Doctor
        public async Task<int> addDoctor(Doctor doctor)
        {
            dbcontext.Add(doctor);
            await dbcontext.SaveChangesAsync();
            return doctor.DoctorId;
        }

        //update
        public async Task<Doctor> updateDoctor(int id,Doctor doctor)
        {
            var existing = await GetDoctorByID(id);
            existing.FirstName = doctor.FirstName;
            existing.LastName = doctor.LastName;
            existing.DepartmentId = doctor.DepartmentId;
            existing.Experience = doctor.Experience;
            existing.JoiningDate = doctor.JoiningDate;

            dbcontext.Update(existing);
            await dbcontext.SaveChangesAsync();
            return existing;
        }

        //Delete

        public async Task<Doctor> deleteDoctor(int id)
        {
            var existing = await GetDoctorByID(id);
            dbcontext.Remove(existing);
            await dbcontext.SaveChangesAsync();
            return existing;
        }
    }
}

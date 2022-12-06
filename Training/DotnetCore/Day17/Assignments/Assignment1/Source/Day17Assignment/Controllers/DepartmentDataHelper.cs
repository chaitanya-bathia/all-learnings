using Day17Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Assignment.Controllers
{
    public class DepartmentDataHelper
    {
        public HospitalDBContext dbContext;

        public DepartmentDataHelper()
        {
            dbContext = new HospitalDBContext();
        }

        //Get all
        public async Task<List<Department>> getAll()
        {
            List<Department> deptList = await dbContext.Departments.Select(x => x).ToListAsync();
            return deptList;
        }

        //post
        public async Task<int> addDept(Department dept)
        {
            dbContext.Add(dept);
            await dbContext.SaveChangesAsync();
            return dept.DepartmentId;
            
        }
    }
}

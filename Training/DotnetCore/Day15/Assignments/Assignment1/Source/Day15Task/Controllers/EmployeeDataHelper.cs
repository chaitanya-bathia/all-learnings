using Day15Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15Task.Controllers
{
    public class EmployeeDataHelper
    {
        public Assignment15DBContext dbContext;

        public EmployeeDataHelper()
        {
            dbContext = new Assignment15DBContext();
        }

        //Get All
        public async Task<List<Employee>> GetEmployees()
        {
            var empList = await dbContext.Employees.Select(x => x).ToListAsync();
            return empList;

        }

        //Get by ID
        public async Task<Employee> GetEmployeeByID(int id)
        {
            var emp = await dbContext.Employees.Where(x => x.EmployeeId == id).FirstAsync();
            return emp;
        }
    }
}

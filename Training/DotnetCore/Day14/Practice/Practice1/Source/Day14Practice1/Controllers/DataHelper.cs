using Day14Practice1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice1.Controllers
{
    public class DataHelper
    {
        private TestDBContext testDBContext;

        public DataHelper()
        {
            testDBContext = new TestDBContext();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await(from employee in testDBContext.Employees
                                  select employee)
                                  .ToListAsync();

            return employees;
        }

        public async Task<int> PostEmployee(Employee employee)
        {
            testDBContext.Add(employee);

            await testDBContext.SaveChangesAsync();
            return employee.EmployeeId;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var emp = await testDBContext.Employees.Where(x => x.EmployeeId == id).SingleAsync() ;

            return emp;
        }

        public async Task<int> updateEmployee(Employee employee)
        {
            testDBContext.Update(employee);
            await testDBContext.SaveChangesAsync();

            return employee.EmployeeId;
        }


        public async Task<int> PutEmployee(int id,Employee incomingEmployee)
        {
            var employee = await GetEmployee(id);

            employee.FirstName = incomingEmployee.FirstName;
            employee.LastName = incomingEmployee.LastName;
            employee.PhoneNumber = incomingEmployee.PhoneNumber;
            employee.ManagerId = incomingEmployee.ManagerId;
            employee.JobId = incomingEmployee.JobId;
            employee.Salary = incomingEmployee.Salary;
            employee.Commission = incomingEmployee.Commission;

            testDBContext.Update(employee);
            await testDBContext.SaveChangesAsync();
            return employee.EmployeeId;
        }


        public async Task<int> DeleteEmployee(int employeeId)
        {
            var employee = await GetEmployee(employeeId);
            testDBContext.Remove(employee);
            testDBContext.SaveChanges();
            return employee.EmployeeId;
        }
    }
}

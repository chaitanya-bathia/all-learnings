using RepositoryPatternPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternPractice.Controllers
{
    public interface IEmployeeService: IRepository<NewEmployee>
    {
        Task<NewEmployee> Add(NewEmployee employee);
        Task<List<NewEmployee>> GetAll();

        Task<NewEmployee> GetByID(int id);

        Task<NewEmployee> Update(int id,NewEmployee employee);

        Task<int> Delete(int id);
    }

    public class EmployeeService : Repository<NewEmployee>, IEmployeeService
    {

        public EmployeeService(TestDBContext testDBContext) : base(testDBContext)
        {

        }
        public NewEmployee Add(NewEmployee employee)
        {
            base.Add(employee);
            return employee;
        }

        public async Task<List<NewEmployee>> GetAll()
        {
            List<NewEmployee> newEmployees = await base.GetAll();
            return newEmployees;
        }

        public async Task<NewEmployee> GetByID(int id)
        {
            NewEmployee emp = await base.GetByID(id);

            return emp;
        }

        public async Task<NewEmployee> Update(int id,NewEmployee employee)
        {
            var emp = await GetByID(id);

            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Salary = employee.Salary;


            await base.Update(emp);
            return emp;
        }

        public async Task<int> Delete(int id)
        {
            NewEmployee emp = await base.Delete(id);
            return emp.EmployeeId;
        }
    }
}

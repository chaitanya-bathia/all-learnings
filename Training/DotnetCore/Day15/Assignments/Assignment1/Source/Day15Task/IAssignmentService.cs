using Day15Task.Controllers;
using Day15Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15Task
{
    public interface IAssignmentService:IRepository<Assignment>
    {
        public Task<Assignment> Add(Assignment assignment);
        public Task<List<Assignment>> Get();

        public Task<Assignment> getByID(int id);

        public Task<Assignment> Delete(int id);

        public Task<Assignment> Update(int id, Assignment assignment);
    }

    public class AssignmentService : Repository<Assignment>, IAssignmentService
    {
        public AssignmentService(Assignment15DBContext context) : base(context)
        {

        }

        //Add Assignment
        public async Task<Assignment> Add(Assignment assignment)
        {
            await base.Add(assignment);
            return assignment;
        }

        //Get Assignments
        public async Task<List<Assignment>> Get()
        {
            var  list = await base.Get();
            return list;
        }

        //Get assignment by ID
        public async Task<Assignment> getByID(int id)
        {
            var item = await base.getByID(id);
            return item;
        }

        //Delete Assignment
        public async Task<Assignment> Delete(int id)
        {
            var item = await base.Delete(id);
            return item;

        }

        //Upate Assignment
        public async Task<Assignment> Update(int id, Assignment assignment)
        {
            var existing = await getByID(id);
            existing.AssignmentNumber = assignment.AssignmentNumber;
            existing.AssignmentName = assignment.AssignmentName;
            await base.Update(existing);
            return existing;
        }
    }
}

using Day14Practice1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private DataHelper dataHelper { get; set; }
        public EmployeeController()
        {
            dataHelper = new DataHelper();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await dataHelper.GetEmployees());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await dataHelper.GetEmployee(id));
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Employee employee)
        {
            var errorList = new List<string>();
            if (employee.EmployeeId == 0)
            {
                errorList.Add("EmployeeID cannot be empty or 0");
            }
            if (employee.FirstName == "")
            {
                errorList.Add("First Name cannot be empty.");
            }
            if (employee.LastName == "")
            {
                errorList.Add("Last Name cannot be empty.");
            }
            if (employee.PhoneNumber == "")
            {
                errorList.Add("Phone Number cannot be empty.");
            }
            if (employee.JobId == 0)
            {
                errorList.Add("JobID cannot be empty or 0.");
            }
            if (employee.Salary == 0)
            {
                errorList.Add("Salary cannot be 0.");
            }
            if (employee.Commission == 0)
            {
                errorList.Add("Commission cannot be 0.");
            }
            if (employee.ManagerId == 0)
            {
                errorList.Add("ManagerID cannot be 0.");
            }
            if (employee.DepartmentId == 0)
            {
                errorList.Add("DepartmentID cannot be 0.");
            }


            if (errorList.Count > 0)
            {
                return BadRequest(errorList);
            }
            else
            {
                return Ok(await dataHelper.PostEmployee(employee));
            }

        }


        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, [FromBody] Employee incomingEmployee)
        {
            return Ok(await dataHelper.PutEmployee(id, incomingEmployee)) ;
        }



        [HttpPatch("{id}")]

        public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<Employee> patchEmployee)
        {
            var employee = await dataHelper.GetEmployee(id);
            patchEmployee.ApplyTo(employee);
            return Ok(await dataHelper.updateEmployee(employee));
        }



        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await dataHelper.DeleteEmployee(id));
        }
    }
}
    
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private IEmployeeService EmployeeService { get; set; }

        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await EmployeeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await EmployeeService.GetByID(id));
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] NewEmployee newEmployee )
        {
            return Ok(await EmployeeService.Add(newEmployee));
        }


        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, [FromBody] NewEmployee newEmployee)
        {
            return Ok(await EmployeeService.Update(id, newEmployee));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await EmployeeService.Delete(id));
        }
    }
}

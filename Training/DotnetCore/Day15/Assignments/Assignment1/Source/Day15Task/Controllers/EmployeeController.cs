using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeDataHelper edh;

        public EmployeeController()
        {
            edh = new EmployeeDataHelper();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await edh.GetEmployees());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await edh.GetEmployeeByID(id));
        }
    }
}

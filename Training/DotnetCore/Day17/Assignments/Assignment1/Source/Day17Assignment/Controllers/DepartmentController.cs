using Day17Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DepartmentDataHelper ddh;
        


        public DepartmentController()
        {
            ddh = new DepartmentDataHelper();
        }

        //get all depts
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await ddh.getAll());
        }


        //post dept
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Department department)
        {
            return Ok(await ddh.addDept(department));
        }


        
    }
}

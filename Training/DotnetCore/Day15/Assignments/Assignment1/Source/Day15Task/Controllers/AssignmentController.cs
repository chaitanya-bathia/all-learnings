using Day15Task.Models;
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
    public class AssignmentController : ControllerBase
    {
        public IAssignmentService assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            this.assignmentService = assignmentService;
        }


        //Post assignment

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Assignment assignment)
        {
            return Ok(await assignmentService.Add(assignment));
        }

        //Get Assignments list

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await assignmentService.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getByID(int id)
        {
            return Ok(await assignmentService.getByID(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await assignmentService.Delete(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Assignment assignment)
        {
            return Ok(await assignmentService.Update(id, assignment));
        }
    }
}

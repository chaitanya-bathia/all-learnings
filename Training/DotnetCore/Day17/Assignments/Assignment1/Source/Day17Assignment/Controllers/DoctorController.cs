using Day17Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day17Assignment.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        DoctorDataHelper doctordh;
        public DoctorController()
        {
            doctordh = new DoctorDataHelper();
        }

        // GET: api/<DoctorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await doctordh.GetDoctors());
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await doctordh.GetDoctorByID(id));
        }

        // POST api/<DoctorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Doctor doctor)
        {
            return Ok(await doctordh.addDoctor(doctor));
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Doctor doctor)
        {
            return Ok(await doctordh.updateDoctor(id, doctor));
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await doctordh.deleteDoctor(id));
        }
    }
}

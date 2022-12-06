using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToysController : ControllerBase
    {
        private ToysDataHelper tdh;
        public ToysController()
        {
            tdh = new ToysDataHelper();
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await tdh.getToys());
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await tdh.getToyByID(id));
        }
    }
}

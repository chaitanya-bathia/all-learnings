using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Services;

namespace Udemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IResourceService resourceService { get; set; }

        public ResourceController( IResourceService service)
        {
            resourceService = service;
        }

        [HttpGet]

        public async Task<IActionResult> getAll()
        {
            return Ok(await resourceService.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> getResourceByID(int id)
        {
            var res = await resourceService.GetByID(id);
            if(res == null || res.ResourceUrl == "")
            {
                return BadRequest();
            }
            return Ok(res);
        }
        

        [HttpGet("topicID/{id}")]

        public async Task<IActionResult> getResourceByTopicID(int id)
        {
            var list = await resourceService.getResourceByTopicID(id);

            if (list.Count == 0)
            {
                return BadRequest();
            }
            return Ok(list);
        }
    }
}

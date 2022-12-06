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
    public class ApplicationObjectController : ControllerBase
    {
        private IObjectService objectService { get; set; }


        public ApplicationObjectController(IObjectService service)
        {
            objectService = service;
        }

        public async Task<IActionResult> getObjects()
        {
            return Ok(await objectService.GetAll());
        }
    }
}

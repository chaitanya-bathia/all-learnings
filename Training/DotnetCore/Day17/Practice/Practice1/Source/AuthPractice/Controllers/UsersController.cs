using AuthPractice.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IJWTManagerRepository _jWTManagerRepository;
        public UsersController(IJWTManagerRepository jWTManagerRepository)
        {
            this._jWTManagerRepository = jWTManagerRepository;
        }

        [Authorize(Roles ="admin")]
        [HttpGet("admin")]

        public List<string> Get()
        {
            var users = new List<string>
            {
                "ADMIN Chaitanya Bathia",
                "ADMIN Demo name",
                "ADMIN Test User"
            };

            return users;
        }

        [Authorize]
        [HttpGet]

        public List<string> GetNew()
        {
            var users = new List<string>
            {
                "Chaitanya Bathia",
                "Demo name",
                "Test User"
            };

            return users;
        }

        [AllowAnonymous]
        [HttpPost]

        [Route("authenticate")]

        public IActionResult Authenticate(Users usersdata, [FromHeader] string role)
        {
            var token = _jWTManagerRepository.Authenticate(usersdata, role);
            if(token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }

    }
}

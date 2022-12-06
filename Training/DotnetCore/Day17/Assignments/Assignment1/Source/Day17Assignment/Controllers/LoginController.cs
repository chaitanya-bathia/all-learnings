using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Assignment.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IJWTManagerRepository _jWTManagerRepository;

        public LoginController(IJWTManagerRepository jWTManagerRepository)
        {
            this._jWTManagerRepository = jWTManagerRepository;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] Users user)
        {
            var token = _jWTManagerRepository.Authenticate(user, null);//solve null reference error here

            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}

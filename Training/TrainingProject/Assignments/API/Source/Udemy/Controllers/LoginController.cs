using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IJWTManagerRepository _jWTManagerRepository;

        public LoginController(IJWTManagerRepository jWTManagerRepository)
        {
            this._jWTManagerRepository = jWTManagerRepository;
        }

        //public LoginDataHelper helper { get; set; }
        //public LoginController()
        //{
        //    helper = new LoginDataHelper();
        //}

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserLoginDTO loginDTO)
        {
            var token = _jWTManagerRepository.Authenticate(loginDTO, null); // sends role value as null and gets from DB if user exists
            if(token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}

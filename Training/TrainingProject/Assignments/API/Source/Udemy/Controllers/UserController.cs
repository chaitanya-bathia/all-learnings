using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;
using Udemy.Services;

namespace Udemy.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService { get; set; }

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await userService.GetAll());
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetUserByID(int id)
        {
            var user = await userService.GetByID(id);
            if(user == null)
            {
                return NotFound("No Such User Exists.");
            }
            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if(user.FullName =="" || user.Email == "" || user.Password == "")
            {
                return BadRequest();
            }
            user.UserType = 1;
            return Ok(await userService.Add(user));
        }


        [AllowAnonymous]
        [HttpPost("login")]

        public async Task<IActionResult> Login([FromBody] UserLoginDTO loginDTO)
        {
            var token = await userService.Login(loginDTO);
            if(token == null)
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}

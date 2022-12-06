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
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseService courseService;

        public CourseController(ICourseService service)
        {
            courseService = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await courseService.GetAll());
        }

        [AllowAnonymous]
        [HttpGet("{id}")]

        public async Task<IActionResult> GetCourseByID(int id)
        {
            var course = await courseService.GetByID(id);

            if (course == null)
            {
                return NotFound("No course Exists.");
            }
            return Ok(course);
        }

        [Authorize(Roles = "Admin,Tutor")]
        [HttpPost]

        public async Task<IActionResult> AddCourse([FromBody] Course course)
        {
            var addedCourse = await courseService.Add(course);
            return Ok(addedCourse);
        }

        [Authorize(Roles = "Admin,Tutor")]
        [HttpDelete]

        public async Task<IActionResult> DeleteCourse(int id)
        {
            var deletedCourse = await courseService.Delete(id);
            return Ok(deletedCourse);
        }


        [AllowAnonymous]
        [HttpGet("TutorAndTopics")]
        public async Task<IActionResult> GetCoursesWithTutorsAndTopics()
        {
            return Ok(await courseService.GetCoursesWithTutorsAndTopics());
        }
    }
}

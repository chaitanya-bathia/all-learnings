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
    public class CategoryController : ControllerBase
    {
        private ICategoryService categoryService;

        public CategoryController(ICategoryService service)
        {
            this.categoryService = service;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await categoryService.GetAll());
        }

        [HttpGet("courses")]

        public async Task<IActionResult> GetCategoriesWithCourses()
        {
            return Ok(await categoryService.GetCategoriesWithCourses());
        }
    }
}

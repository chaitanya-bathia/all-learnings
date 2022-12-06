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
    public class TopicController : ControllerBase
    {
        private ITopicService topicService;

        public TopicController(ITopicService service)
        {
            topicService = service;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetTopics()
        {
            return Ok(await topicService.GetAll());
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<IActionResult> PostTopic([FromBody] Topic topic)
        {
            return Ok(await topicService.Add(topic));
        }
    }
}

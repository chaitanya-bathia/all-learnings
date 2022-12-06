using Day14Practice2.Models;
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
    public class OrderController : ControllerBase
    {
        private OrderDataHelper odh;

        public OrderController()
        {
            odh = new OrderDataHelper();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await odh.GetOrders());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            var errorList = new List<string>();

            if(order.CustomerId == 0)
            {
                errorList.Add("There needs to be ID of customer in an order.");
            }

            if (errorList.Count > 0)
            {
                return BadRequest(errorList);
            }
            else
            {
                return Ok(await odh.PostOrder(order));
            }
        }
    }
}

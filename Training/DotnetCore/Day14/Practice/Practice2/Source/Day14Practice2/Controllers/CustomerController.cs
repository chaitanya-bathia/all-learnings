using Day14Practice2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerDataHelper cdh;

        public CustomerController()
        {
            cdh = new CustomerDataHelper();
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await cdh.GetCustomers());
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetByID(int id)
        {
            var customer = await cdh.GetCustomerByID(id);

            return Ok(customer);
        }

        [HttpPost]

        public async Task<IActionResult> PostCustomer([FromBody] Customer customer)
        {
            var errorList = new List<string>();

            if(customer.CustomerName == "")
            {
                errorList.Add("Customer Name Cannot be empty");
            }
            if (customer.Gender == "")
            {
                errorList.Add("Customer Gender is required.");
            }

            if (errorList.Count > 0)
            {
                return BadRequest(errorList);
            }
            else
            {
                return Ok(await cdh.PostCustomer(customer));
            }
        }

        //Updating existing Customer

        [HttpPut("{id}")]

        public async Task<IActionResult> PutCustomer(int id, [FromBody] Customer customer)
        {
            return Ok(await cdh.PutCustomer(id, customer));
        }

        //Partially Update Customer
        [HttpPatch("{id}")]

        public async Task<IActionResult> PatchCustomer(int id,[FromBody] JsonPatchDocument<Customer> patchCustomer)
        {
            var customer = await cdh.GetCustomerByID(id);
            patchCustomer.ApplyTo(customer);
            return Ok(await cdh.patchCustomer(customer)) ;
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await cdh.deleteCustomer(id));
        }
    }
}

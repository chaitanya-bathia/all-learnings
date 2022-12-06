using Day14Practice2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice2.Controllers
{
    public class CustomerDataHelper
    {

        private ToyCompanyDBContext dbContext;

        public CustomerDataHelper()
        {
            dbContext = new ToyCompanyDBContext();
        }

        //Get all customers

        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer> customers = await dbContext.Customers.Select(x => x).ToListAsync();

            return customers;
        }

        //Get Customer By ID

        public async Task<Customer> GetCustomerByID(int customerID)
        {

            var customer = await dbContext.Customers.Where(x => x.CustomerId == customerID).FirstAsync();
            return customer;
        }

        //Post new Customer
        public async Task<int> PostCustomer(Customer customer)
        {
            dbContext.Add(customer);
            await dbContext.SaveChangesAsync();
            return customer.CustomerId;
        }


        public async Task<Customer> PutCustomer(int id,Customer customer)
        {
            var existingcustomer = await dbContext.Customers.Where(x => x.CustomerId == id).FirstAsync();

            existingcustomer.CustomerName = customer.CustomerName;
            existingcustomer.Gender = customer.Gender;
            await dbContext.SaveChangesAsync();

            return existingcustomer;
        }


        public async Task<Customer> patchCustomer(Customer customer)
        {
            dbContext.Update(customer);
            await dbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<int> deleteCustomer(int id)
        {
            Customer customer = await GetCustomerByID(id);
            dbContext.Remove(customer);
            await dbContext.SaveChangesAsync();
            return customer.CustomerId;
        }
    }
}

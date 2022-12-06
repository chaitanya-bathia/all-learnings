using Day14Practice2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice2.Controllers
{
    public class OrderDataHelper
    {
        public ToyCompanyDBContext dbContext;

        public OrderDataHelper()
        {
            dbContext = new ToyCompanyDBContext();
        }

        public async Task<List<Order>> GetOrders()
        {
            List<Order> orders = await dbContext.Orders.Select(x => x).ToListAsync();
            return orders;
        }

        public async Task<int> PostOrder(Order order)
        {
            dbContext.Add(order);
            await dbContext.SaveChangesAsync();
            return order.OrderId;
        }
    }
}

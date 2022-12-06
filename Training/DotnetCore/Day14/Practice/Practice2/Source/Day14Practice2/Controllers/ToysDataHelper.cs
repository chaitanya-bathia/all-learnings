using Day14Practice2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice2.Controllers
{
    public class ToysDataHelper
    {
        public ToyCompanyDBContext dbContext;

        public ToysDataHelper()
        {
            dbContext = new ToyCompanyDBContext();
        }


        //Get All Toys
        public async Task<List<Toy>> getToys()
        {
            var toysList = await dbContext.Toys.Select(x=>x).ToListAsync();

            return toysList;
        }

        //Get Toy By ID
        
        public async Task<Toy> getToyByID(int toyID)
        {
            var toy = await dbContext.Toys.Where(x => x.ToyId == toyID).FirstAsync();

            return toy;
        }
    }
}

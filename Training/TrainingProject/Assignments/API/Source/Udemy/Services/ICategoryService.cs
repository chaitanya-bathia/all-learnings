using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Services
{
    public interface ICategoryService : IRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithCourses();
    }

    public class CategoryService : Repository<Category>, ICategoryService
    {

        private udemy2437chaitanyaContext dbcontext = new udemy2437chaitanyaContext();
        public CategoryService(udemy2437chaitanyaContext context) : base(context)
        {

        }

        public async Task<List<Category>> GetAll()
        {
            var categoryList = await base.GetAll();
            return categoryList;
        }

        public async Task<List<Category>> GetCategoriesWithCourses()
        {
            return await dbcontext.Categories.Include(x => x.Courses).ToListAsync();
        }
    }
}

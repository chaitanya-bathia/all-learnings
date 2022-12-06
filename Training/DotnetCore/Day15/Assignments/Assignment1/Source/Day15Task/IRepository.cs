using Day15Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15Task.Controllers
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Get();
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> getByID(int id);
        Task<TEntity> Delete(int id);
        Task<TEntity> Update(TEntity entity);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        public Assignment15DBContext dbContext;
        public Repository(Assignment15DBContext context)
        {
            dbContext = context;
        }

        //Add new Entity
        public async Task<T> Add(T entity)
        {
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        //Get All Entities
        public async Task<List<T>> Get()
        {
            var list = await dbContext.Set<T>().Select(x=>x).ToListAsync();
            return list;
        }
        
        //Get by ID

        public async Task<T> getByID(int id)
        {
            var item = await dbContext.Set<T>().FindAsync(id);
            return item;
        }

        //Delete
        public async Task<T> Delete(int id)
        {
            var item = await dbContext.Set<T>().FindAsync(id);
            dbContext.Remove(item);
            await dbContext.SaveChangesAsync();
            return item;
        }

        //Update
        public async Task<T> Update(T entity)
        {
            dbContext.Update(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using RepositoryPatternPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternPractice.Controllers
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetByID(int id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int id);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        public TestDBContext dbContext;

        public Repository(TestDBContext dbcontext)
        {
            dbContext = dbcontext;
        }

        public async Task<T> Add(T entity)
        {
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAll()
        {

            var demo = await dbContext.Set<T>().Select(x => x).ToListAsync();

            return demo;
        }

        public async Task<T> GetByID(int id)
        {
            var data = await dbContext.Set<T>().FindAsync(id);
            return data;
        }

        public async Task<T> Update(T entity)
        {
            dbContext.Update(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var ent = await dbContext.Set<T>().FindAsync(id);

            dbContext.Remove(ent);
            await dbContext.SaveChangesAsync();
            return ent;
        }
    }
}

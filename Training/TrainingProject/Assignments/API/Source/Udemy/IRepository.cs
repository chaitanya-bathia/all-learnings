using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy
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

        udemy2437chaitanyaContext dbcontext;

        public Repository(udemy2437chaitanyaContext context)
        {
            dbcontext = context;
        }
        public async Task<T> Add(T entity)
        {
            dbcontext.Add(entity);
            await dbcontext.SaveChangesAsync();
            return entity;
        }
        public async Task<List<T>> GetAll()
        {
            var listResult = await dbcontext.Set<T>().Select(x => x).ToListAsync();
            return listResult;
        }

        public async Task<T> GetByID(int id)
        {
            var result = await dbcontext.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<T> Update(T entity)
        {
            dbcontext.Update(entity);
            await dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var data = await dbcontext.Set<T>().FindAsync(id);
            
            dbcontext.Remove(data);
            await dbcontext.SaveChangesAsync();
            return data;
        }

    }

}

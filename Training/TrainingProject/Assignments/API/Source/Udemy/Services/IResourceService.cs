using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Services
{
    public interface IResourceService :IRepository<Resource>
    {
        Task<List<Resource>> getResourceByTopicID(int id);
    }

    public class ResourceService : Repository<Resource>, IResourceService
    {
        public ResourceService(udemy2437chaitanyaContext context) : base(context)
        {
        }

        public async Task<List<Resource>> getResources()
        {
            return await base.GetAll();
        }

        public async Task<List<Resource>> getResourceByTopicID(int id)
        {
            var all = await base.GetAll();
            return (all.Where(x => x.TopicId == id).ToList());
        }

        public async Task<Resource> getResourceByID(int id)
        {
            return await base.GetByID(id);
        }
    }
}

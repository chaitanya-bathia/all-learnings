using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Services
{
    public interface IObjectService :IRepository<ApplicationObject>
    {
    }

    public class ObjectService : Repository<ApplicationObject>, IObjectService
    {
        public ObjectService(udemy2437chaitanyaContext context) : base(context)
        {
        }

        public async Task<List<ApplicationObject>> getObjects()
        {
            return await base.GetAll();
        }
    }

}

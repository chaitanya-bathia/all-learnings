using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Services
{
    public interface ITopicService : IRepository<Topic>
    {

    }

    public class TopicService : Repository<Topic>, ITopicService
    {
        public TopicService(udemy2437chaitanyaContext context) : base(context)
        {

        }

        public async Task<List<Topic>> GetAll()
        {
            var topics = await base.GetAll();
            return topics;
        }

        public async Task<Topic> GetTopicByID(int id)
        {
            var topic = await base.GetByID(id);
            return topic;
        }

        public async Task<Topic> AddTopic(Topic topic)
        {
            var addedTopic = await base.Add(topic);
            return addedTopic;
        }

        public async Task<Topic> UpdateTopic(Topic topic)
        {
            var updatedTopic = await base.Update(topic);
            return updatedTopic;
        }

        public async Task<Topic> DeleteTopic(int id)
        {
            var deletedTopic = await base.Delete(id);
            return deletedTopic;
        }
    }

}

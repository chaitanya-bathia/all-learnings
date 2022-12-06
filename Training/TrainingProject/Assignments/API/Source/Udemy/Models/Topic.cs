using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Resources = new HashSet<Resource>();
        }

        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}

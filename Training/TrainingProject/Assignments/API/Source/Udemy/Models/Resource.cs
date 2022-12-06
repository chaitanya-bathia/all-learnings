using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class Resource
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceUrl { get; set; }
        public int? TopicId { get; set; }

        public virtual Topic Topic { get; set; }
    }
}

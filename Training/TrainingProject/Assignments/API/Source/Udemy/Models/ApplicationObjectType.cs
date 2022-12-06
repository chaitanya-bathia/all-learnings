using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class ApplicationObjectType
    {
        public ApplicationObjectType()
        {
            ApplicationObjects = new HashSet<ApplicationObject>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<ApplicationObject> ApplicationObjects { get; set; }
    }
}

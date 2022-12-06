using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class ApplicationObject
    {
        public ApplicationObject()
        {
            Categories = new HashSet<Category>();
            Courses = new HashSet<Course>();
            UserStatusNavigations = new HashSet<User>();
            UserUserTypeNavigations = new HashSet<User>();
        }

        public int ApplicationObjectId { get; set; }
        public string ApplicationObjectName { get; set; }
        public int? TypeId { get; set; }

        public virtual ApplicationObjectType Type { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<User> UserStatusNavigations { get; set; }
        public virtual ICollection<User> UserUserTypeNavigations { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
            InverseParentCategory = new HashSet<Category>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? Status { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ApplicationObject StatusNavigation { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Category> InverseParentCategory { get; set; }
    }
}

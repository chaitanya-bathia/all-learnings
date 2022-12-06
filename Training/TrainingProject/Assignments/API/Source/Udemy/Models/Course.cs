using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class Course
    {
        public Course()
        {
            Carts = new HashSet<Cart>();
            PurchaseWiseCourses = new HashSet<PurchaseWiseCourse>();
            Topics = new HashSet<Topic>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? SubCategoryId { get; set; }
        public decimal? Price { get; set; }
        public int? TutorId { get; set; }
        public int? Status { get; set; }

        public virtual ApplicationObject StatusNavigation { get; set; }
        public virtual Category SubCategory { get; set; }
        public virtual User Tutor { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<PurchaseWiseCourse> PurchaseWiseCourses { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}

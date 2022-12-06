using System;
using System.Collections.Generic;

#nullable disable

namespace Udemy.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Courses = new HashSet<Course>();
            Purchases = new HashSet<Purchase>();
        }

        public int? UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public int? Status { get; set; }

        public virtual ApplicationObject StatusNavigation { get; set; }
        public virtual ApplicationObject UserTypeNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }

    public class UserLoginDTO
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}

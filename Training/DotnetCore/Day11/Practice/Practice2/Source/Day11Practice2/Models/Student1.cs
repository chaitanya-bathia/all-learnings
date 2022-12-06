using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice2.Models
{
    public partial class Student1
    {
        public Student1()
        {
            StudentDetails = new HashSet<StudentDetail>();
            StudentHours = new HashSet<StudentHour>();
            StudentPresents = new HashSet<StudentPresent>();
        }

        public int Studentid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentDetail> StudentDetails { get; set; }
        public virtual ICollection<StudentHour> StudentHours { get; set; }
        public virtual ICollection<StudentPresent> StudentPresents { get; set; }
    }
}

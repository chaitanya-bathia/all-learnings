using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternPractice.Models
{
    public partial class StudentHour
    {
        public int StudentHoursId { get; set; }
        public int? StudentId { get; set; }
        public DateTime? Datex { get; set; }
        public TimeSpan? Hours { get; set; }

        public virtual Student1 Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Day17Assignment.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? DoctorId { get; set; }
        public int? HealthcareAssistantId { get; set; }
        public string Disease { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual HealthcareAssistant HealthcareAssistant { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}

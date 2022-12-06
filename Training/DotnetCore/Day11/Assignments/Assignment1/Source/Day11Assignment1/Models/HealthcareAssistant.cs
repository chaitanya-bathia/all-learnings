using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Assignment1.Models
{
    public partial class HealthcareAssistant
    {
        public HealthcareAssistant()
        {
            Patients = new HashSet<Patient>();
        }

        public int HealthcareAssistantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Experience { get; set; }
        public DateTime? JoiningDate { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}

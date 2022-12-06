using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Assignment1.Models
{
    public partial class Drug
    {
        public Drug()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}

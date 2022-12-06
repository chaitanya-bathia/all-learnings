using System;
using System.Collections.Generic;

#nullable disable

namespace Day15Task.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Assignments = new HashSet<Assignment>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? CitizenShipId { get; set; }
        public string CitizenshipLegislationCode { get; set; }
        public string CitizenshipStatus { get; set; }
        public DateTime? CitizenshiptoDate { get; set; }
        public string CorrespondanceLanguage { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string DisplayName { get; set; }
        public DateTime? DriversLicenseExpiryDate { get; set; }
        public int? DriversLicenseId { get; set; }
        public string DriversLicenseIssuingCountry { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public string Ethinicity { get; set; }
        public string HomeFaxCountryCode { get; set; }
        public string HomePhoneCountryCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Honors { get; set; }
        public string MaritialStatus { get; set; }
        public string MilitaryVetStatus { get; set; }
        public int? NationalId { get; set; }
        public string NationalIdcountry { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}

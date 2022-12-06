using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            Customer1s = new HashSet<Customer1>();
            EmailAddresses = new HashSet<EmailAddress>();
            PersonCreditCards = new HashSet<PersonCreditCard>();
            PersonPhones = new HashSet<PersonPhone>();
        }

        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public virtual ICollection<Customer1> Customer1s { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}

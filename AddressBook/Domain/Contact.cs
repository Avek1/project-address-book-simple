using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook.Domain
{
    public class Contact
    {
        public int Id { get; set; }             // added this.  do i need it?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
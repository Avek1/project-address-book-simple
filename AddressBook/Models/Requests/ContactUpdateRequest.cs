using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook.Models.Requests
{
    public class ContactUpdateRequest : ContactAddRequest
    {
        public int Id { get; set; }
    }
}
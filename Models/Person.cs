using System;
using System.Collections.Generic;

namespace BankApi.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        //navigation properties
        public List<Account> Accounts { get; set; } = new List<Account>();

    }
}
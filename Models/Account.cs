using System;
using System.Collections.Generic;

using BankApi.ModelEnums;

namespace BankApi.Models
{
    public class Account
    {

        public ulong AccountId { get; set; }
        public AccountType Type { get; set; }
        public decimal Balance { get; set; }
        public Guid PersonId { get; set; } //FK

        //navigation properties
        public Person Person { get; set; }
        public List<Transaction> Transactions { get; set; }

        //concurrency
        public byte[] LastUpdate { get; set; }

    }
}
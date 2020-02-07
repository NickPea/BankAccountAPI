using System;
using System.Collections.Generic;
using BankApi.ModelEnums;

namespace BankApi.Models
{

    public class Transaction
    {

        public DateTime DateTime { get; set; } //PK
        public decimal AccountId { get; set; } //PK-FK
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        //navigation properties
        public Account Account { get; set; }

        //concurrency
        public byte[] ConcurrencyToken { get; set; }


    }

}
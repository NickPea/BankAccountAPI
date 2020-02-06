using System;
using System.Collections.Generic;
using BankApi.ModelEnums;

namespace BankApi.Models
{

    public class Transaction
    {

        public DateTime DateTime { get; set; } //PK
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public long AccountId { get; set; } //PK-FK

        //navigation properties
        public Account Account { get; set; }


    }

}
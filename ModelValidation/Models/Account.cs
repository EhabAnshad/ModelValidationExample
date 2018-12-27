using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.Currency)]
        public double CurrentBalance { get; set; }

        public List<CreditCard> CreditCards { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Account()
        {
            Id = Guid.NewGuid();
        }
    }
}

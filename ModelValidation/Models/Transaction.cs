using ModelValidation.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Transaction
    {
        [Key]
        public Int64 TransactionId { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        public TransactionType TransactionType { get; set; }
    }
}

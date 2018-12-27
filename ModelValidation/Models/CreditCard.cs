using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class CreditCard
    {
        [Key]
        public Guid Id { get; set; }

        [CreditCard]
        public string CreditCardNumber { get; set; }

        [RegularExpression("\\d{2}/\\d{2}", ErrorMessage = "Please enter valid expiry date yy/mm")]
        public string ExpiryDate { get; set; }

        [RegularExpression("\\d{3}", ErrorMessage = "Please enter valid CCV")]
        public int CCV { get; set; }

        public CreditCard()
        {
            Id = Guid.NewGuid();
        }
    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Compare("EmailAddress", ErrorMessage = "Emails mismatch")]
        public string VerifyEmailAddress { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public List<Account> AccountList { get; set; }
    }
}

    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
     using System.Collections.Generic;



    namespace Login_Registration.Models
    {
        public class User
        {

            [Key]
            public int UserId { get; set; }

            [Required]
            [MinLength(2, ErrorMessage="First Name must be more than 2")]
            public string FirstName { get; set; }

            [Required]
            [MinLength(2, ErrorMessage="Last Name must be more than 2")]
            
            public string LastName { get; set; }

            
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [MinLength(4, ErrorMessage="Password must be 4 characters or longer!")]
            public string Password { get; set; }

            public List<Transaction> CreatedTransactions {get;set;}
            // -----------------------------------------------------------------
            // date
            // -----------------------------------------------------------------
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            [NotMapped]
            [Compare("Password")]
            [DataType(DataType.Password)]
            public string Confirm {get;set;}
        }
    }
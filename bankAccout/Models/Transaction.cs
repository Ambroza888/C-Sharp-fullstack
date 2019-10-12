    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;



    namespace Login_Registration.Models
    {
      public class Transaction
      {
        [Key]
        public int transID {get;set;}
        public decimal Amount {get;set;}
        public int UserId {get;set;}
        public User Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
      }
    }
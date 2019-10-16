    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    



    namespace TheWall.Models
    {
        public class Comment
        {
          public int CommentId {get;set;}

          [Required]
          [MinLength(2, ErrorMessage="Need atleast 2 letters please !")]
          public string CommentText {get;set;}
          
          public int UserId {get;set;}
          public User User {get;set;}
          public Message Message {get;set;}
          public int MessageId {get;set;}
          public DateTime CreatedAt {get;set;} = DateTime.Now;
          public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }
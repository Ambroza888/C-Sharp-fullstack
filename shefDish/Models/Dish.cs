using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

    namespace shefDish.Models
    {
        public class Dish
        {
          [Key]
          public int DishId {get;set;}
          [Required]
          public string NameDish {get;set;}
          [Required]
          [Range(0,int.MaxValue)]
          public int Calories {get;set;}
          [Required]
          public string Description {get;set;}
          [Required]
          [Range(1,6)]
          public int Tastiness {get;set;}
          public int ChefId {get;set;}
          public Chef Chef {get;set;}
          public DateTime CreatedAt {get;set;} = DateTime.Now;
          public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }
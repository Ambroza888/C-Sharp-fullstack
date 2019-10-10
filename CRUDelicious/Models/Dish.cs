    using System.ComponentModel.DataAnnotations;
    using System;
    namespace CRUDelicious.Models
    {
        public class Dish
        {
            [Key]
            [Required]
            public int DishId { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            [Display(Name = "Chef's Name")]
            public string Chef { get; set; }

            [Required]
            [Range(0,5)]
            public int Tastiness { get; set; }

            [Required]
            [Display(Name="# of Calories")]
            [Range(1,int.MaxValue)]
            public int Calories { get; set; }

            [Required]
            public string Description {get;set;}
            public DateTime Created_at {get;set;} = DateTime.Now;
            public DateTime Updated_at {get;set;} = DateTime.Now;
        }
    }
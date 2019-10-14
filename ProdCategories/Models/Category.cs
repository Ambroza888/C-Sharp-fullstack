using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProdCategories.Models
{
  public class Category
  {

    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<Association> Associations {get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
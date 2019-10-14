using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProdCategories.Models
{
  public class Association
  {

    [Key]
    public int AssociationId { get; set; }
    public int ProductId {get;set;}
    public int CategoryId {get;set;}
    public Category Category {get;set;}
    public Product Product {get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
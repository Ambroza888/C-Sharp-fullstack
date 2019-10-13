using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProdCategories.Models
{
  public class Catergory
  {

    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    List<Association> CATEGtoPROD {get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
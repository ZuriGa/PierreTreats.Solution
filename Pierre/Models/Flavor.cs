using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Pierre.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Display(Name = "Flavor Name")]
    public string FlavorName { get; set; }
    public string Description { get; set; }
  }
}


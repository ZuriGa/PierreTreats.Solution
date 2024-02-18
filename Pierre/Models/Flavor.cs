using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Pierre.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Display(Name = "Flavor Name")]
    [Required(ErrorMessage = "Flavor name is required")]
    public string FlavorName { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }

  }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Pierre.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Display(Name = "Treat Name")]
    [Required(ErrorMessage = "Treat name is required")]
    public string TreatName { get; set; }
    public string Description { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }
  }

}

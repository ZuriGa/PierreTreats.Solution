using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Pierre.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Display(Name = "Treat Name")]
    public string TreatName { get; set; }
    
  }

}

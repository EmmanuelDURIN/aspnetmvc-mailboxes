using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MailBoxManager.Models
{
  public class MailBox
  {
    public int Id { get; set; }

    [Required]
    [StringLength(4,MinimumLength =4)]
    public string Reference { get; set; }
    [Required]
    public string Name { get; set; }
    public string Color { get; set; }
    public string ImagePath { get; set; }
    [Range(1, 1000)]
    public double Height { get; set; }
    [Range(1, 1000)]
    public double Width { get; set; }
    [Range(1,1000)]
    public double Depth { get; set; }
  }
}
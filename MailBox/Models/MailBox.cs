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

    public string Reference { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string ImagePath { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
  }
}
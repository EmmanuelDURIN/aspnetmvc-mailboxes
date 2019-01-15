using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailBoxManager.Models
{
  public class MailBox
  {
    //Reference : string
    //Name : string
    //Color : String
    //Height : double
    //Width : double
    //Depth : double
    //ImagePath : string
    public string Reference { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string ImagePath { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
  }
}
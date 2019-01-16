using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MailBoxManager.Models
{
  // Responsabilité : initialiser le context (=la base) avec qq données
  public class MailBoxInitializer : DropCreateDatabaseAlways<MailBoxContext>
  {
    // Seed = planter, ensemencer
    protected override void Seed(MailBoxContext context)
    {
      base.Seed(context);
      context.MailBoxes.Add(new MailBox
      {
        Color = "Anthracite",
        Name = "Sunset Mailbox",
        Reference = "X624",
        Depth = 400,
        Width = 350,
        Height = 250,
        ImagePath = "/Images/Mailbox/mailbox1.jpg"
      });
      context.MailBoxes.Add(new MailBox
      {
        Color = "Anthracite",
        Name = "Ideal Mailbox",
        Reference = "X625",
        Depth = 400,
        Width = 350,
        Height = 250,
        ImagePath = "/Images/Mailbox/mailbox1.jpg"
      });
      context.MailBoxes.Add(new MailBox
      {
        Color = "Anthracite",
        Name = "Saint Herblain Mailbox",
        Reference = "X626",
        Depth = 400,
        Width = 350,
        Height = 250,
        ImagePath = "/Images/Mailbox/mailbox1.jpg"
      });
      context.SaveChanges();
    }
  }

}
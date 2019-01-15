using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MailBoxManager.Models
{
  public class MailBoxContext : DbContext
  {
    public MailBoxContext()
            // faire le lien avec le ConnectionString 
            //: base("name= MailBoxConnectionString")
    // ou bien ne rien mettre et c’est une base localDB qui porte 
    // le nom pleinement qualifié de la classe de DbContext
    {
      Debug.WriteLine(this.Database.Connection.ConnectionString);
      // On veut logger les requêtes SQL passées par EFx sur la DB
      this.Database.Log = text => Debug.WriteLine(text);
    }
    public DbSet<MailBox> MailBoxes { get; set; }
  }
}
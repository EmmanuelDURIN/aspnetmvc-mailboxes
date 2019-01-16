using System.Data.Entity;
using System.Diagnostics;

namespace MailBoxManager.Models
{
  // Responsabilité: DbContext lire et écrire nos Entités dans la DB
  public class MailBoxContext : DbContext
  {
    public MailBoxContext()
    // faire le lien avec le ConnectionString 
    //: base("name= MailBoxConnectionString")
    // ou bien ne rien mettre et c’est une base localDB qui porte 
    // le nom pleinement qualifié de la classe de DbContext
    {
      //Debug.WriteLine(this.Database.Connection.ConnectionString);
      // On veut logger les requêtes SQL passées par EFx sur la DB
      this.Database.Log = text =>
      {
        Debug.WriteLine("******************************************************");
        Debug.WriteLine(text);
        Debug.WriteLine("******************************************************");
      };
    }
    // pour chaque entité {classe <---> table} on expose un DbSet
    // qui permet de requêter
    public DbSet<MailBox> MailBoxes { get; set; }
  }
}
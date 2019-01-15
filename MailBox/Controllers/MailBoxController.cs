using MailBoxManager.Models;
using System.Web.Mvc;

namespace MailBoxManager.Controllers
{
  public class MailBoxController : Controller
  {
    // GET: MailBox
    public ActionResult Index(string reference)
    {
      MailBox mailbox = new MailBox
      {
        Name="Sunset mailbox",
        Width=200,
        Height=180,
        Depth=200,
        Reference=reference,
        Color ="Red",
        ImagePath="/Images/mailbox1.jpg"
      };
      // transmettre la mailbox en tant que modele de la vue
      return View(model : mailbox);
    }
  }
}
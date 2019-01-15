using MailBoxManager.Models;
using System.Linq;
using System.Web.Mvc;

namespace MailBoxManager.Controllers
{
  public class MailBoxController : Controller
  {
    // GET: MailBox
    public ActionResult Reference(string reference)
    {
      MailBox mailbox = null;
      using (var context = new MailBoxContext())
      {
        mailbox = context.MailBoxes.FirstOrDefault(
             mb => mb.Reference.ToUpper() == reference.ToUpper());
      }
      // transmettre la mailbox en tant que modele de la vue
      return View(model : mailbox);
    }
  }
}
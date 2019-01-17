using MailBoxManager.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MailBoxManager.Controllers
{
  public class MailBoxController : Controller
  {
    private MailBoxContext db = new MailBoxContext();
    public MailBoxController()
    {

    }
    // GET: MailBox
    public ActionResult Index()
    {
      return View(db.MailBoxes.ToList());
    }
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
      // La vue par défaut qui est recherchée est la vue dont le nom correspond à l'action ...
      return View(viewName:"Details", model: mailbox );
    }
    // GET: MailBox/Details/5
    public ActionResult Details(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      MailBox mailBox = db.MailBoxes.Find(id);
      if (mailBox == null)
      {
        return HttpNotFound();
      }
      return View(mailBox);
    }
    // GET: MailBox/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: MailBox/Create
    // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
    // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(
      [Bind(Include = "Id,Reference,Name,Color,ImagePath,Height,Width,Depth")] MailBox mailBox)
    {
      if (ModelState.IsValid)
      {
        db.MailBoxes.Add(mailBox);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      return View(mailBox);
    }

    // GET: MailBox/Edit/5
    public ActionResult Edit(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      MailBox mailBox = db.MailBoxes.Find(id);
      if (mailBox == null)
      {
        return HttpNotFound();
      }
      return View(mailBox);
    }

    // POST: MailBox/Edit/5
    // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
    // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "Id,Reference,Name,Color,ImagePath,Height,Width,Depth")] MailBox mailBox)
    {
      if (ModelState.IsValid)
      {
        db.Entry(mailBox).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(mailBox);
    }

    // GET: MailBox/Delete/5
    public ActionResult Delete(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      MailBox mailBox = db.MailBoxes.Find(id);
      if (mailBox == null)
      {
        return HttpNotFound();
      }
      return View(mailBox);
    }

    // POST: MailBox/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
      MailBox mailBox = db.MailBoxes.Find(id);
      db.MailBoxes.Remove(mailBox);
      db.SaveChanges();
      // pattern Post-Get
      // L'action de suppression (création, édition,...) est dissociée du visionnage
      // Post -> Supprime
      // Get -> Voir la liste des MailBox 
      // ( c'est uniquement cette deuxième requête qui est visée en cas de Refresh)
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        db.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MailBox.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      // la date peut être passée par :
      //    -1) ViewData/ViewBag
      ViewBag.Date = DateTime.Now;
      //    OU
      //    -2) Model
      return View(model : DateTime.Now);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";
      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
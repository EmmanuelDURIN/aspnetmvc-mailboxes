using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MailBoxManager
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      // Route spécifique,
      // à mettre devant la route classique
      routes.MapRoute(
        name: "boitesAuxLettres",
        url: "boites-aux-lettres/{reference}",
        defaults: new {
          controller = "MailBox",
          action = "Index",
          reference = "X425" }
      );
      // Route classique, inchangée = catch-all
      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proje.Etkinlik.API
{

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "User",
                url: "{controller}/{action}/{email}",
                defaults: new { email = UrlParameter.Optional}
            );
        }
    }
}


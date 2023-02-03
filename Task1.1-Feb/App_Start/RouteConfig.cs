using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Task1._1_Feb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );



                  routes.MapRoute(
                name: "Default1",
                url: "Products/Create",
                defaults: new { controller = "Products", action = "Create", id = UrlParameter.Optional }
            ) ;
        }
    }
}

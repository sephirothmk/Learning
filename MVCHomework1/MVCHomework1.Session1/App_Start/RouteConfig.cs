using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCHomework1.Session1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "BookRoute",
                url: "books",
                defaults: new { controller = "Books", action = "Books", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "NewsRoute",
                url: "news",
                defaults: new { controller = "Books", action = "News", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Books", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

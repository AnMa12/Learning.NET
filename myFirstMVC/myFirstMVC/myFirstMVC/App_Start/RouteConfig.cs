using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace myFirstMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Concatenare",
                url: "{controller}/{action}/{param1}/{param2}",
                defaults: new
                {
                    controller = "Example",
                    action = "Concatenare",
                    param1 = UrlParameter.Optional,
                    param2 = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "HelloWorld",
                url: "{controller}/{action}/{name}/{id}",
                defaults: new
                {
                    controller = "HelloWorld",
                    action = "Index",
                    name = "World",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}

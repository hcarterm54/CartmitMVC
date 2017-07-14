using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CartmitMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Course/arboretum
            routes.MapRoute(
                name: "Course",
                url: "course/{name}",
                defaults: new {controller = "Course", action = "Search", name = UrlParameter.Optional}
            );

            // /Cuisine/french
            routes.MapRoute(
                name: "Cuisine",
                url: "cuisine/{name}",
                defaults: new { controller = "Cuisine", action = "Search", name = UrlParameter.Optional }
            );

            // /Home
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

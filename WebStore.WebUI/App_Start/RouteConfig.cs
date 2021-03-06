﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "null",
                url: "Strona{page}",
                //komentarz: zdefiniowanie trasy domyślnej poprzez zmianę parametru controller oraz action
                defaults: new { controller = "Product", action = "List" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //komentarz: zdefiniowanie trasy domyślnej poprzez zmianę parametru controller oraz action
                defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            );

            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(null, "", new { controller = "Product", action = "List", category = (string)null, page = 1 });
            //routes.MapRoute(null, "Strona{page}", new { controller = "Product", action = "List", category = (string)null }, new { page = @"\d+" });
            //routes.MapRoute(null, "{category}", new { controller = "Product", action = "List", page = 1 });
            //routes.MapRoute(null, "{category}/Strona{page}", new { controller = "Product", action = "List" }, new { page = @"\d+" });
            //routes.MapRoute(null, "{controler}/{action}");
        }
    }
}

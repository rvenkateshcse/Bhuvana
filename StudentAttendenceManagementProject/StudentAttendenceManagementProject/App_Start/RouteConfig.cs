﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentAttendenceManagementProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

                  routes.MapRoute(
                name: "Register",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Registration", action = "Register", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Staff",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "StaffPage", action = "Staff", id = UrlParameter.Optional }
           );
            routes.MapRoute(
            name: "Student",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "StudentPage", action = "Student", id = UrlParameter.Optional }
         );
        }
    }
}

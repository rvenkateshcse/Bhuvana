using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class RegistrationController : Controller
    {
        
        public ActionResult Register(string Sn,string Un,string Pwd)
        {
            int Re = Services.LogInservice.Register(Sn,Un,Pwd);
            if (Re == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (Re == 0)
            {
                ViewBag.Result = "Enter Your Details";
            }
            return View();
        }
    }
}   
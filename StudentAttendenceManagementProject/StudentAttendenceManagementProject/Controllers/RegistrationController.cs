using StudentAttendenceManagementProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class RegistrationController : Controller
    {
        
        public ActionResult Register(string SN,string UN,string PWD)
        {
            int Re = Services.LogInservice.Register(SN,UN,PWD);
            if (Re == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}   

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
        
        public ActionResult Register(string Sn,string Un,string Pwd)
        {
            int Re = Services.LogInservice.Register(Sn,Un,Pwd);
            if (Re == 1)
            {
                ViewBag.Show = "Data Inserted";
            }
        
            return View();
        }
    }
}   

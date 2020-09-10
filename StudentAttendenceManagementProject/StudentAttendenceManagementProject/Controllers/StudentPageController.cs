using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class StudentPageController : Controller
    {
       
        public ActionResult Student(string Sn)
        {
            string Re = Services.LogInservice.Student(Sn);
            ViewBag.Ans = Re;
            return View();
        }
    }
}
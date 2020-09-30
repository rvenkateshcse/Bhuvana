using StudentAttendenceManagementProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(string Un, string Pwd, string Rol)
        {

            int re = Services.LogInservice.Login(Un, Pwd);
            if (re == 1)
            {
                if (Rol == "Staff")
                {
                    return RedirectToAction("Staff", "StaffPage");
                }
                else if (Rol == "Student")
                {
                    return RedirectToAction("Student", "StudentPage");
                }
            }
            else if (re == 0)
            {
                ViewBag.Res= "Enter Correct UserName and Password";
                
            }
            return View();
        }



    }
}
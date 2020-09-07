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
        public ActionResult Index(StudentModel obj)
        {
            string UserName =obj.Un;
            string Password = obj.Pwd;
            string Role =obj.Rol;
            int re = Services.LogInservice.Login(UserName, Password);
                if (re == 1)
                {
                    if (Role== "Staff")
                    {
                      return RedirectToAction("Staff");
                    }
                    else if (Role == "Student")
                    {
                       return RedirectToAction("Student");
                    }
                }
                else if (re == 0)
                {
                    ViewBag.Result = "Enter Correct UserName and Password";
                }
            return View();
        }

       
       
    }
}
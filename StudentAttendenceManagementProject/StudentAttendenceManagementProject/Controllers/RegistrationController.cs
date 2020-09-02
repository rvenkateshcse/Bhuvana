using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register(Models.StudentModel student)
        {
            int Re = Services.LogInservice.Register(student.StudentName,student.UserName,student.Password);
            if (Re == 1)
            {
                Response.Redirect("Home/Index");
            }
            else if (Re == 0)
            {
                ViewBag.Result = "Enter Your Details";
            }
            return View();
        }
    }
}   
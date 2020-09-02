using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Models.StudentModel student)
        {
            int re = Services.LogInservice.Login(student.UserName, student.Password, student.Role);
            if(re==1)
            {
                if (student.Role == "Staff")
                {
                    Response.Redirect("StaffPage/Staff");
                }
             else   if (student.Role == "Student")
                {
                    Response.Redirect("StudentPage/Student");
                }
            }
            else if(re==0)
            {
                ViewBag.Result = "Enter Correct UserName and Password";
            }
            return View();
        }

       
       
    }
}
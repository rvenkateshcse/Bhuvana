using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class StudentPageController : Controller
    {
        // GET: StudentPage
        public ActionResult Student(Models.StudentModel student)
        {
            int Re = Services.LogInservice.Student(student.StudentName);
            if (Re == 1)
            {
                ViewBag.Message = "Data Updated";
            }
            else if (Re == 0)
            {
                ViewBag.Message = "Enter Student Attendence";
            }
            return View();
        }
    }
}
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
            string Re = Services.LogInservice.Student(student.StudentName);
            if (Re != " ")
            {
                
            }
            return View();
        }
    }
}
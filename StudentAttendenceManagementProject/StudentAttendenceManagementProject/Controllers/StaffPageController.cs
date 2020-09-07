using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class StaffPageController : Controller
    {
        // GET: StaffPage
        public ActionResult Staff(Models.StudentModel student)
        {
            int Re = Services.LogInservice.Staff(student.Sn, student.Ad);
            if (Re == 1)
            {
                ViewBag.Message="Data Updated";
            }
            else if (Re == 0)
            {
                ViewBag.Message = "Enter Student Attendence";
            }
            return View();
        }
    }
}
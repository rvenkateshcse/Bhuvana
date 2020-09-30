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
        public ActionResult Staff(string Sn, string Ads)
        {
            int Ad = Convert.ToInt32(Ads);
            int Re = Services.LogInservice.Staff(Sn,Ad);
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

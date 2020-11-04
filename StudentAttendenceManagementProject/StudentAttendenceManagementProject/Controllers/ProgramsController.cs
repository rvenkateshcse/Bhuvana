using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class ProgramsController : Controller
    {
        // GET: Programs
        public ActionResult Programs(string P1,string Input1,string Input2)
        {
            if (P1 == "StringReverse")
            {
                string re = Services.LogInservice.StringReverse(Input1);
                ViewBag.Ans = re;
            }
            if (P1 == "StringPalindrome")
            {
                string re = Services.LogInservice.StringPalindrome(Input1);
                ViewBag.Ans = re;
            }
            return View();
        }
    }
}
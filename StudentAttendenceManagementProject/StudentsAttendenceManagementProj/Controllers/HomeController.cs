using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace StudentsAttendenceManagementProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44311/api/Student");
            }
            return View();
        }
    }
}

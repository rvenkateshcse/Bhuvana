using Display_CurrentDate_using_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Display_CurrentDate_using_Web_Api.Controllers
{
    public class HomeController : Controller
    {
        masterEntities1 date = new masterEntities1();
        public ActionResult Index()
        {
            ViewBag.res = date;
            return View();
        }
    }
}

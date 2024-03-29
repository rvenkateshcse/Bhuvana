﻿using Repository;
using StudentAttendenceManagementProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace StudentAttendenceManagementProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Un, string Pwd, string Rol)
        {
            int re =Services.LogInservice.Login(Un, Pwd);
            if (re == 1)
            {
                if (Rol == "staff")
                {
                    return RedirectToAction("Staff", "StaffPage");
                }
                else if (Rol == "student")
                {
                    return RedirectToAction("Student", "StudentPage");
                }
                else if (Rol == "Programs")
                {
                    return RedirectToAction("Programs", "Programs");
                }
            }
            else if (re == 0)
            {
                ViewBag.Message= "Enter Correct UserName and Password";
                return View();
                
            }
            return View();
        }



    }
}
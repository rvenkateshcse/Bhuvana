using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginForm.Models;

namespace LoginForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {

            LoginModel obj = new LoginModel();

            return View(obj);

        }

        [HttpPost]

        public ActionResult Index(LoginModel objuserlogin)

        {

            var display = Userloginvalues().Where(m => m.UserName == objuserlogin.UserName && m.UserPassword == objuserlogin.UserPassword).FirstOrDefault();

            if (display != null)

            {

                ViewBag.Status = "CORRECT UserName and Password";

            }

            else

            {

                ViewBag.Status = "INCORRECT UserName or Password";

            }

            return View(objuserlogin);

        }

        public List<LoginModel> Userloginvalues()

        {

            List<LoginModel> objModel = new List<LoginModel>();

            objModel.Add(new LoginModel { UserName = "user1", UserPassword = "password1" });

            objModel.Add(new LoginModel { UserName = "user2", UserPassword = "password2" });

            objModel.Add(new LoginModel { UserName = "user3", UserPassword = "password3" });

            objModel.Add(new LoginModel { UserName = "user4", UserPassword = "password4" });

            objModel.Add(new LoginModel { UserName = "user5", UserPassword = "password5" });

            return objModel;

        }
    }
}

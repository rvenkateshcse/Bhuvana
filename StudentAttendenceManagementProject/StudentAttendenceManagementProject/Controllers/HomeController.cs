using StudentAttendenceManagementProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace StudentAttendenceManagementProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Un,string Pwd,string Rol,string Receiver,string subject,string Message)
        {
            int re = Services.LogInservice.Login(Un, Pwd);
            if (re == 1)
            {
                var senderEmail = new MailAddress("rbhuvaneswariece@gmail.com");
                var receiverEmail = new MailAddress(Receiver,"Receiver");
                var sub = subject;
                var body = Message;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod=SmtpDeliveryMethod.Network,
                    Use DefaultCredentials = false,
                    Credentials=new NetworkCredential(senderEmail,Address)
                };
                if (Rol == "staff")
                {
                    return RedirectToAction("Staff", "StaffPage");
                }
                else if (Rol == "student")
                {
                    return RedirectToAction("Student", "StudentPage");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class SendEmailController : Controller
    {
        // GET: SendEmail
        public ActionResult SendEmail(string Receiver,string Subject,string Message)
        {
           
                var SenderEmail = new MailAddress("rbhuvaneswariece@gmail.com", "rbhuvaneswari");
                var ReceiverEmail = new MailAddress( "rbhuvaneswari01@outlook.com");
                var Password = "Bhuvana@123";
                var subject = Subject;
                var message = Message;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(SenderEmail.Address, Password)
                };
                using (var mess = new MailMessage(SenderEmail, ReceiverEmail)
                {
                    Subject = Subject,
                    Body = message
                })
                {
                    smtp.Send(mess);
                }
            
            return View();
        }
    }
}

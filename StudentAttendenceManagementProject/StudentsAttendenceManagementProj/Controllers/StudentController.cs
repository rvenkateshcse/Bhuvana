using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentsAttendenceManagementProj.Models;

namespace StudentsAttendenceManagementProj.Controllers
{
    public class StudentController : ApiController
    {
       public IHttpActionResult Login(LoginClass Lc)
        {
            int re = Services.LogInservice.Login(Lc.UserName, Lc.Password);
            return Ok();
        }
    }
}

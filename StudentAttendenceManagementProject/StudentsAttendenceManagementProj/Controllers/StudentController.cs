using System;
using System.Collections.Generic;
using Services;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentsAttendenceManagementProj.Models;

namespace StudentsAttendenceManagementProj.Controllers
{
    public  class StudentController : ApiController
    {
       public IHttpActionResult Login(LoginClass Lc)
        {
            Student student = new Student();
            int re = student.Login(Lc.UserName, Lc.Password);
            return Ok();
        }
    }
}

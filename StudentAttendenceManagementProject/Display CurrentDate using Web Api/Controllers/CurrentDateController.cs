using Display_CurrentDate_using_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Display_CurrentDate_using_Web_Api.Controllers
{
    public class CurrentDateController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DateTime CurrentDate = new DateTime();
            using (masterEntities1 db = new masterEntities1())
            {
                HttpResponseMessage Response;
                Response = Request.CreateResponse("select*from[CurrentDateView]");
                return Response;
            }
                
        }
    }
}

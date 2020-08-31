using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Attendance_Management_System
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string StudentName = Request.QueryString["StudentName"];
            string UserName = Request.QueryString["UserName"];
            string Password = Request.QueryString["Password"];
            if((TextBox1.Text==UserName)&&(TextBox2.Text == Password))
            {
               
            }
        }
    }
}
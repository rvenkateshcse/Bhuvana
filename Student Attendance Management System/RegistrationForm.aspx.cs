using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student_Attendance_Management_System
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string StudentName = TextBox1.Text;
            string UserName = TextBox2.Text;
            string Password = TextBox3.Text;
            string  Role ;
            for(int i=0;i<ListBox1.Items.Count;i++)
            {
                Role = ListBox1.Items[i].Text;
            }            
            Response.Redirect("LoginForm.aspx?StudentName="+StudentName);
            Response.Redirect("LoginForm.aspx?UserName=" + UserName);
            Response.Redirect("LoginForm.aspx?Password=" + Password);
        }

    }
}
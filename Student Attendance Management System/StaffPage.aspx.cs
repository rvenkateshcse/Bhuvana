using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student_Attendance_Management_System
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
           SqlConnection con=new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update StudentAttendanceTable set StudentName='" + TextBox1.Text + "', AttendedDays='" + TextBox2.Text + "' where StudentName='" + TextBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            Label3.Text = "Data Updated";
            con.Close();
        }
    }
}
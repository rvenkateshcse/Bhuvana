using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UserLoginProcess
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Password = TextBox2.Text;
            con.Open();
            string qry = "select * from UserLoginProcess where UserName='" + Name + "' and UserPassword='" + Password + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Response.Redirect("Process.aspx");
            }

            else
            {
                Label3.Text = "UserName and PassWord is Incorrect";
            }
            con.Close();
        }

       
    }
}
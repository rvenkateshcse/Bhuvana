using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace StudentLogin

{
    public partial class StudentLoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con=  new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Password = TextBox2.Text;
            con.Open();
            string qry = "select * from StudentLogin where  Name='" + Name + "' and Password='" + Password + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                Response.Redirect("LogIn.aspx");

            }
            else
            {
                Label1.Text = "UserName and PassWord is Incorrect";
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Regitration.aspx");
        }
    }
}
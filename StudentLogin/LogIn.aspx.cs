using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace StudentLogin
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
           
            string qry = "select * from StudentLogin where Name=Name ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                TextBox1.Text = sdr.GetValue(0).ToString();
                TextBox2.Text = sdr.GetValue(1).ToString();
                TextBox3.Text = sdr.GetValue(2).ToString();

            }
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLoginForm.aspx");
        }
    }
}
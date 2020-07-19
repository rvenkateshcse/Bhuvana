using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace UserLogin
{
    public partial class UserLoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string userpassword = TextBox2.Text;
            con.Open();
            string qry = "select * from Userlogin where username='" + username + "' and userpassword='" + userpassword + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                Label1.Text = "Login Sucess...";
               
            }
            else
            {
                Label1.Text = "UserName and PassWord is Incorrect";
            }
            con.Close();
        }
    }
}
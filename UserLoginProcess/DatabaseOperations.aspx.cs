using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UserLoginProcess
{
    public partial class DatabaseOperations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true;");

        protected void Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            Label5.Text = "Data Is Inserted";
            con.Close();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            Label5.Text = " ";
            SqlCommand cmd = new SqlCommand("update student set StudentName='" + TextBox1.Text + "',RollNo='" + TextBox2.Text + "', Percentage='" + TextBox3.Text + "' where StudentName='" + TextBox1.Text + "'", con);
             cmd.ExecuteNonQuery();
            Label5.Text="Data Updated";
            con.Close();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            Label5.Text = " ";
            SqlCommand cmd = new SqlCommand("delete from student where StudentName='" + TextBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            Label5.Text="Data Deleted";
            con.Close();
        }

        protected void Select_Click(object sender, EventArgs e)
        {
            con.Open();
            Label5.Text = " ";
            string qry = $"select * from Student where StudentName= '"+TextBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                TextBox1.Text = sdr.GetValue(0).ToString();
                TextBox2.Text = sdr.GetValue(1).ToString();
                TextBox3.Text = sdr.GetValue(2).ToString();

            }
           
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Process.aspx");
        }
    }



}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLoginProcess
{
    public partial class Maths : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Input1 = Convert.ToInt32(TextBox1.Text);
            int Input2 = Convert.ToInt32(TextBox2.Text);
            string str = TextBox3.Text;
            if(str=="Add")
            {
                TextBox4.Text = Convert.ToString(Input1 + Input2);
            }
          else  if (str == "Sub")
            {
                TextBox4.Text = Convert.ToString(Input1 - Input2);
            }
          else  if (str == "Mul")
            {
                TextBox4.Text = Convert.ToString(Input1 * Input2);
            }
           else if (str == "Div")
            {
                TextBox4.Text = Convert.ToString(Input1 / Input2);
            }
            else
            {
                Label5.Text = "Enter Correct Operation";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Process.aspx");
        }
    }
}
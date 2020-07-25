using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLoginProcess
{
    public partial class StringFunctions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Input1 = TextBox1.Text;
            string Input2 = TextBox2.Text;
            string str = TextBox3.Text;
            if(str== "StringLength")
            {
                int count = 0;
                foreach (char ch in Input1)
                {
                    count += 1;
                }
                TextBox4.Text= Convert.ToString(count);
            }
            else if (str == "CharacterSearching")
            {
                char x = Convert.ToChar(Input2);
                string output = "";
                for (int i = 0; i <= Input1.Length-1; i++)
                {
                    if (Input1[i] == x)
                    {
                        output = "Data found";
                        break;
                    }
                    else if (Input1[i] == Input1[Input1.Length-1 ])
                    {
                        output = "Data Notfound";
                    }
                }

                TextBox4.Text= output;
            }
            
        }
    }
}
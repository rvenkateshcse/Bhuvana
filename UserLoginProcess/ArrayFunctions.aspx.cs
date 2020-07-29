using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLoginProcess
{
    public partial class ArrayFunctions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBox2.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Add(TextBox3.Text);
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Remove(TextBox3.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[] Input1 = new int[ListBox1.Items.Count];
            int[] Input2 = new int[ListBox2.Items.Count];
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                Input1[i] = Convert.ToInt32(ListBox1.Items[i].ToString());
            }
            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                Input2[i] = Convert.ToInt32(ListBox2.Items[i].ToString());
            }
            if (TextBox1.Text == "LargestElement")
            {
                for (int i = 1; i < Input1.Length; i++)
                {
                    if (Input1[0] < Input1[i])
                    {
                        Input1[0] = Input1[i];
                    }
                }
                ListBox3.Items.Add(Input1[0].ToString());
            }
         else   if (TextBox1.Text == "SecondLargest")
            {
                int large = 0,seclarge=0;
                for (int i = 0; i < Input1.Length; i++)
                {
                    if(Input1[i]>large)
                    {
                        seclarge = large;
                        large = Input1[i];
                        
                    }
                    else if(Input1[i]>seclarge&&Input1[i]<large)
                    {
                        seclarge = Input1[i];
                    }
                }
                ListBox3.Items.Add(seclarge.ToString());
            }
         else  if (TextBox1.Text == "ElementSearch")
            {
                int flag = 0;
                for(int i=0;i<Input1.Length;i++)
                {
                    if(Input1[i]==Input2[0])
                    {
                        flag++;
                    }
                }
                if (flag == 1)
                    Label5.Text = "Element Present In Array";
                else
                    Label5.Text = "Element Not  Present In Array";
            }
        }

        
    }

}


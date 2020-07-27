using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLoginProcess
{
    public partial class Numbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Input1 = Convert.ToInt32(TextBox1.Text);
            string str = TextBox3.Text;
            if (str == "ArmstrongNumber")
            {
                int sum = 0, rem, temp = Input1;
                while (Input1 != 0)
                {
                    rem = Input1 % 10;
                    sum = sum + (rem * rem * rem);
                    Input1 = Input1 / 10;
                }
                if (sum == temp)
                    TextBox4.Text = " Armstrong number";
                else
                    TextBox4.Text = " Input Is Not An Armstrong number";
            }
         else   if (str == "PalindromeNumber")
            {
                int res = 0, temp = Input1;
                while (Input1 != 0)
                {
                    res = res * 10;
                    res = res + Input1 % 10;
                    Input1 = Input1 / 10;
                }
                if (res == temp)
                    TextBox4.Text = " Palindrome number";
                else
                    TextBox4.Text = " Input Is Not Palindrome number";
            }
          else  if (str == "ReverseNumber")
            {
                int res = 0;
                while (Input1 != 0)
                {
                    res = res * 10;
                    res = res + Input1 % 10;
                    Input1 = Input1 / 10;
                }
                TextBox4.Text = Convert.ToString(res);
            }
         else   if (str == "Factorial")
            {
                int result = 1;
                for (int i = 1; i <= Input1; i++)
                {
                    result = result * i;

                }

                TextBox4.Text = Convert.ToString(result);
            }
          else  if (str == "SumOfDigits")
            {
                int output = 0, rem;
                while (Input1 > 0)
                {
                    rem = Input1 % 10;
                    output = output + rem;
                    Input1 = Input1 / 10;

                }
                TextBox4.Text = Convert.ToString(output);
            }
          else  if (str == "DecimalToBinary")
            {
                string output = "";
                while (Input1 > 0)
                {
                    int rem = Input1 % 2;
                    output = Convert.ToString(rem) + output;
                    Input1 = Input1 / 2;
                }
                TextBox4.Text = output;
            }
          else  if (str == "NumbersInCharacter")
            {
                int res = 0, rem;
                string output = "";
                while (Input1 != 0)
                {
                    res = res * 10;
                    res = res + Input1 % 10;
                    Input1 = Input1 / 10;
                }
                while (res > 0)
                {
                    rem = res % 10;
                    switch (rem)
                    {
                        case 1:
                            output += "One";
                            break;
                        case 2:
                            output += "Two";
                            break;
                        case 3:
                            output += "Three";
                            break;
                        case 4:
                            output += "Four";
                            break;
                        case 5:
                            output += "Five";
                            break;
                        case 6:
                            output += "Six";
                            break;
                        case 7:
                            output += "Seven";
                            break;
                        case 8:
                            output += "Eight";
                            break;
                        case 9:
                            output += "Nine";
                            break;
                        case 0:
                            output += "Zero";
                            break;
                    }
                    res = res / 10;
                }
               TextBox4.Text=  output;
            }
            else if (str == "PrimeNumber")
            {
                int k = 0;
                for(int i=1;i<=Input1;i++)
                {

                    if (Input1 % i == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                    TextBox4.Text = "PrimeNumber";
                else
                    TextBox4.Text = "Not a PrimeNumber";

            }
            else
            {
                Label6.Text = "Enter Correct Operation";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Process.aspx");
        }
    }
    
}
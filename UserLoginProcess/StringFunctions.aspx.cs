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
            if (str == "StringLength")
            {
                int count = 0;
                foreach (char ch in Input1)
                {
                    count += 1;
                }
                TextBox4.Text = Convert.ToString(count);
            }
            else if (str == "CharacterSearching")
            {
                char x = Convert.ToChar(Input2);
                string output = "";
                for (int i = 0; i <= Input1.Length - 1; i++)
                {
                    if (Input1[i] == x)
                    {
                        output = "Data found";
                        break;
                    }
                    else if (Input1[i] == Input1[Input1.Length - 1])
                    {
                        output = "Data Notfound";
                    }
                }

                TextBox4.Text = output;
            }
            else if (str == "DateAndTime")
            {
                DateTime inputdate = Convert.ToDateTime(Input1);
                DateTime dt = DateTime.Today;
                string output = "";
                if (dt.Date == inputdate.Date)
                {
                    output = "Today";
                }
                if (inputdate.Date == dt.AddDays(-1))
                {
                    output = "Yesterday";
                }
                if (inputdate.Date == dt.AddDays(+1))
                {
                    output = "Tomorrow";
                }

                if (inputdate.Date >= dt.AddDays(-7) && inputdate.Date < dt.AddDays(-1))
                {
                    output = "Last Week";
                }
                if (inputdate.Date <= dt.AddDays(+7) && inputdate.Date > dt.AddDays(+1))
                {
                    output = "Next Week";
                }

                TextBox4.Text = output;
            }
            else if (str == "DuplicateElement")
            {
                int count;
                string output = "";
                int len = Input1.Length - 1;
                for (int i = 0; i <= len; i++)
                {
                    count = 1;
                    for (int j = i + 1; j <= len; j++)
                    {
                        if (Input1[i] == Input1[j])
                        {
                            count += 1;

                        }

                    }
                    if (count > 1)
                        output += Input1[i];

                }
                TextBox4.Text = output;
            }
            else if (str == "Vowel")
            {
                int count = 0;
                for (int i = 0; i < Input1.Length; i++)
                {
                    if (Input1[i] == 'a' || Input1[i] == 'e' || Input1[i] == 'i' || Input1[i] == 'o' || Input1[i] == 'u' || Input1[i] == 'A' || Input1[i] == 'E' || Input1[i] == 'I' || Input1[i] == 'O' || Input1[i] == 'U')
                        count += 1;
                }
                TextBox4.Text = Convert.ToString(count);

            }
            else if (str == "Palindrome")
            {
                int len = Input1.Length - 1;
                string temp = Input1;
                string revstr = "";
                string output = "";
                while (len >= 0)
                {
                    revstr += Input1[len];
                    len--;
                }
                if (revstr == temp)
                {
                    output = "Palindrome";
                }
                else
                {
                    output = "Not Palindrome";
                }
                TextBox4.Text = output;
            }
            else if (str == "Reverse")
            {
                int len = Input1.Length - 1;
                string output = "";
                while (len >= 0)
                {
                    output += Input1[len];
                    len--;
                }
                TextBox4.Text = output;
            }
            else if (str == "UniqueElement")
            {
                int count = 0;
                int len = Input1.Length - 1;
                string output = "";
                for (int i = 0; i <= len; i++)
                {
                    for (int j = i + 1; j <= len; j++)
                    {
                        if (Input1[i] == Input1[j])
                        {
                            count += 1;
                        }
                    }
                }
                if (count > 0)
                {
                    output = "Duplicate characters in string";
                }
                else
                {
                    output = "Unique characters in string";
                }
                TextBox4.Text = output;
            }
            else if (str == "WordCount")
            {
                int word = 1;
                for (int i = 0; i < Input1.Length; i++)
                {
                    if (Input1[i] == ' ' || Input1[i] == '\n')
                    {
                        word += 1;
                    }
                }
                TextBox4.Text = Convert.ToString(word);
            }
            else
                Label5.Text = "Enter correct Option";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Process.aspx");
        }
    }
}
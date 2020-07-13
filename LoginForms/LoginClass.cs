using System;
using System.Collections.Generic;
using System.Text;

namespace LoginForms
{
  public  static class LoginClass
    {
        public static string  Login(object input1,object input2)
        {
            string output = string.Empty;
            string username = Convert.ToString(input1);
            string userpassword = Convert.ToString(input2);

            if (username == "user" && userpassword == "password")
                output = "Successful";
            else
                output = "Enter correct username and password";
            return output;


        }
    }
}

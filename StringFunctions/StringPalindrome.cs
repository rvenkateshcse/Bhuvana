using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
  public static  class StringPalindrome
    {
        /// <summary>
        /// Check the Input String Is  Palindrome Or Not
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static string Find(object input1)
        {
            string str = Convert.ToString(input1);
            int len = str.Length - 1;
            string temp = str;
            string revstr = "";
            string output = "";
            while (len >= 0)
            {
                revstr += str[len];
                len--;
            }
            if(revstr==temp)
            {
                output = "Palindrome";
            }
            else
            {
                output = "Not Palindrome";
            }
            return output;
        }
    }
}

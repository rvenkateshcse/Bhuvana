using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public  static class PalindromeNumber
    {
        public static String find(object input1)
        {
            string output = string.Empty;
            int num = Convert.ToInt32(input1);
            int  res=0, temp = num;
            while (num != 0)
            {
                res = res * 10;
                res = res + num % 10;
                num = num / 10;
            }
            if (res == temp)
                output = " Palindrome number";
            return output;
           
        }
    }
}

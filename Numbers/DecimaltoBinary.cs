using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
   public static class DecimaltoBinary
    {
        public static  string convert(object input1)
        {
            int n = Convert.ToInt32(input1);
            string output="";
            while(n>1)
            {
            int  rem=  n % 2;
                output = Convert.ToString(rem) + output;
                n = n / 2;
            }
            output = Convert.ToString(n) + output;
            return output;
        }
    }
}

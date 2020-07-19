using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
   public static class DecimaltoBinary
    {
        /// <summary>
        /// Converts Decimal Number To Binary Number
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static  string Converts(object input1)
        {
            int n = Convert.ToInt32(input1);
            string output="";
            while(n>0)
            {
            int  rem=  n % 2;
                output = Convert.ToString(rem) + output;
                n = n / 2;
            }
            return output;
        }
    }
}

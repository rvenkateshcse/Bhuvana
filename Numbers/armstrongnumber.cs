using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public static  class Armstrongnumber
    {
        /// <summary>
        /// Print  the Input Integer is Armstrong Number Or Not
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static string Check(object input1)
        {
            string output = string.Empty;
            int num = Convert.ToInt32(input1);
            int sum = 0, rem, temp = num;
            while(num!=0)
            {
                rem = num % 10;
                sum = sum + (rem*rem*rem);
                num = num / 10;
            }
            if (sum == temp)
                output = " Armstrong number";
            return output;
        }
    }
}

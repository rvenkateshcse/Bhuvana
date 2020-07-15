using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public static  class Sumofdigits
    {
        public static int find(object input1)
        {
            int num = Convert.ToInt32(input1);
            int output=0,rem;
            while(num>0)
            {
                rem = num % 10;
                output = output + rem;
                num = num / 10;

            }
            return output;
        }
    }
}

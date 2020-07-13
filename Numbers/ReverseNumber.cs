using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public static class ReverseNumber
    {
        public static int Reverse(object input1)
        {
           
            int num = Convert.ToInt32(input1);
            int res = 0, temp = num;
            while (num != 0)
            {
                res = res * 10;
                res = res + num % 10;
                num = num / 10;
            }
            return res;
            
        }
}
}

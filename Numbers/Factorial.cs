using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public static  class Factorial
    {
        public static int calculate(object input1)
        {
            int num = Convert.ToInt32(input1);
            int result=1;
            if (num == 1)
                return 1;
            else
            {
                for(int i=num;i>=1;i--)
                {
                    result = result * num;
                    
                }
            }
            return result;
        }
    }
}

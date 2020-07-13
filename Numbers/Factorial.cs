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
            for(int i=1;i<=num;i++)
            {
                    result = result * i;
                    
            }
            
            return result;
        }
    }
}

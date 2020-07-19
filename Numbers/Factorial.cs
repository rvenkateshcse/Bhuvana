using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public static  class Factorial
    {
        /// <summary>
        /// Calculate the Factorial Of Input Integer
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static int Calculate(object input1)
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

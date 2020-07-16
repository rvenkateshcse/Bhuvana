using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
 public static   class StringLength
    {
        public static int calculate(object input1)
        {
            string str = Convert.ToString(input1);
            int count = 0;
            foreach(char ch in str)
            {
                count += 1;
            }
            return count;
        }
    }
}

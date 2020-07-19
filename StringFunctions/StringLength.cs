using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
 public static   class StringLength
    {
        /// <summary>
        /// Returns Length Of Input String Without Using String Function
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static int Calculate(object input1)
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

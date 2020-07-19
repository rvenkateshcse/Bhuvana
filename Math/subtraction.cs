using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
  public static  class Subtraction
    {
        /// <summary>
        /// Returns Of Two Input Integers
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public static int Sub(object input1, object input2)
        {
            return Convert.ToInt32(input1) - Convert.ToInt32(input2);
        }
    }
}

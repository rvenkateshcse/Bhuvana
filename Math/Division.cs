using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
  public static  class Division
    {
        /// <summary>
        /// Returns Division Of Two Input Integers
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public static int Div(object input1, object input2)
        {
            return Convert.ToInt32(input1) / Convert.ToInt32(input2);
        }
    }
}

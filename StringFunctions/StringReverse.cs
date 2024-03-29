﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
  public static  class StringReverse
    {
        /// <summary>
        /// Returns Reverse Of Input String
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public  static string Reverse(object input1)
        {
            string str = Convert.ToString(input1);
            int len = str.Length - 1;
            string output = "";
            while(len>=0)
            {
                output += str[len];
                len--;
            }
            return output;
        }
    }
}

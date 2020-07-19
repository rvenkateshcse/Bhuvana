using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
    
    public static class UniqueElement
    {
        /// <summary>
        /// Check All Characters Of Input String Is Unique
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static string Return(object input1)
        {
            string str = Convert.ToString(input1);
            int count = 0;
            int len = str.Length - 1;
            string output = "";
            for(int i=0;i<=len;i++)
            {
                for(int j=i+1;j<=len;j++)
                {
                    if (str[i] == str[j])
                    {
                        count += 1;
                    }
                }
            }
            if (count > 0)
            {
                output = "Duplicate characters in string";
            }
            else
            {
                output = "Unique characters in string";
            }
            return output;

        }
    }
}

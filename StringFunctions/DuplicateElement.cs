using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
    public static class DuplicateElement
    {
        public static string find (object input1)
        {
            string str = Convert.ToString(input1);
            int count ;
            string output = "";
            int len = str.Length - 1;
            for (int i = 0; i <= len; i++)
            {
                count = 1;
                for (int j = i+1; j <= len; j++)
                {
                    if (str[i] == str[j])
                    {
                        count += 1;
                        
                    }
                    
                }
                if (count > 1)
                    output += str[i];
            }
            return output;

        }
    }
}

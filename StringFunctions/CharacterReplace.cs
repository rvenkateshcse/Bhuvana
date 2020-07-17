using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
    public static class CharacterReplace
    {
        public static string Replace(object input1, object input2)
        {
            string str = Convert.ToString(input1);
            string c = Convert.ToString(input2);
            StringBuilder sb = new StringBuilder(str);
            sb.Replace(str, c);
            string output = Convert.ToString(sb);
            return output; 
        } 
        
        
    }
}

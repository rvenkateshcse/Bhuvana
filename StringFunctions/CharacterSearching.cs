using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
    public static class CharacterSearching
    {
        public static string search(object input1, object input2)
        {
            string str = Convert.ToString(input1);
            char x = Convert.ToChar(input2);
            string output = "";
           for(int i=0;i<str.Length;i++)
            {
                if (str[i] == x)
                {
                    output = "Data found";
                    break;
                }
                else if (str[i] == str[str.Length - 1])
                {
                    output = "Data Notfound";
                }
            }
           
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
    public static class Divisionbythreenotbysix
    {
        public static string Run(object input1)
        {
            string output = string.Empty;
            int num = Convert.ToInt32(input1);
            if (num % 3 == 0 && num % 6 != 0)
               output="Number divided by 3 not by 6";
            return output;
        }
    }
}

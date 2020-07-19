using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
  public static  class NumofVowels
    {
        /// <summary>
        /// Print Number Of Vowels Present in Input String
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static int Print(object input1)
        {
            string str = Convert.ToString(input1);
            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                    count += 1;
            }
            return count;
        }
    }
}

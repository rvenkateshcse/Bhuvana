using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
 public static   class WordCount
    {
        /// <summary>
        /// Returns a Number of Words  in Input Sentence
       /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static int Count(object input1)
        {
            string str = Convert.ToString(input1);
            int word = 1;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==' '||str[i]=='\n')
                {
                    word += 1;
                }
            }
            return word;

        }
    }
}

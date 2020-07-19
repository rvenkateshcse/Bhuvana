using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
  public static  class NumbersInCharacters
    {
        /// <summary>
        /// Print the Input Integer In Characters
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static string Print(object input1)
        {
            int num = Convert.ToInt32(input1);
            int res = 0,rem ;
            string output = "";
            while (num != 0)
            {
                res = res * 10;
                res = res + num % 10;
                num = num / 10;
            }
            while(res>0)
            {
                rem = res % 10;
                switch(rem)
                {
                    case 1:
                        output += "One";
                        break;
                    case 2:
                        output += "Two";
                        break;
                    case 3:
                        output += "Three";
                        break;
                    case 4:
                        output += "Four";
                        break;
                    case 5:
                        output += "Five";
                        break;
                    case 6:
                        output += "Six";
                        break;
                    case 7:
                        output += "Seven";
                        break;
                    case 8:
                        output += "Eight";
                        break;
                    case 9:
                        output += "Nine";
                        break;
                }
                res = res / 10;
            }
            return output;


        }
    }
}

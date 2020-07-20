using System;
using System.Collections.Generic;
using System.Text;

namespace StringFunctions
{
  public static  class DateandTime
    {
        /// <summary>
        /// Returns  Day,Week & Month For Input Date
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public static string Calculate(object input1)
        {

            DateTime inputdate = Convert.ToDateTime(input1);
            DateTime dt = DateTime.Today;
            string output = "";
            if(dt.Date==inputdate.Date)
            {
                output = "Today";
            }
            if(inputdate.Date==dt.AddDays(-1))
            {
                output = "Yesterday";
            }
            if (inputdate.Date == dt.AddDays(+1))
            {
                output = "Tomorrow";
            }

            if (inputdate.Date >= dt.AddDays(-7) && inputdate.Date <= dt.AddDays(-1))
            {
                output = "Last Week";
            }
            if (inputdate.Date <= dt.AddDays(+7) && inputdate.Date >= dt.AddDays(+1))
            {
                output = "Next Week";
            }
            if (inputdate.Date >= dt.AddDays(-30) && inputdate.Date <= dt.AddDays(-1))
            {
                output = "Last Month";
            }
            if (inputdate.Date <= dt.AddDays(+30) && inputdate.Date >= dt.AddDays(+1))
            {
                output = "Last Month";
            }
            return output;
        }
    }
}

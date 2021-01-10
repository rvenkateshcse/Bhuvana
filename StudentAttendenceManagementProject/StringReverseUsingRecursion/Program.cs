using System;

namespace StringReverseUsingRecursion
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Your String");
            string Str = Convert.ToString(Console.ReadLine());
            
            
            string res = Display(Str);
            Console.WriteLine(res);
        }


        static  string Display(string Str)
        {
            if (Str.Length == 1)
                return Str;
            else
            {
                string newstr = "";
                for (int i=0;i<Str.Length-1;i++)
                {
                    newstr += Str[i];
                }
              return Str[Str.Length - 1] + Display(newstr);
            }

            return "'";
        }

    }
}
    

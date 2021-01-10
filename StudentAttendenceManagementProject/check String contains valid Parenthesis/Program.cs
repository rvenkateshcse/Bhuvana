using System;

namespace check_String_contains_valid_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            int oc = 0, cc = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == '{')
                    oc += 1;
                else if (str[i] == '}')
                    cc += 1;
            }
            if(oc==cc)
            {
                Console.WriteLine("The String Contains Valid Parenthesis");
            }
            else
            {
                Console.WriteLine("The String Does not contains Valid Parenthesis");
            }
            Console.ReadLine();
        }
    }
}

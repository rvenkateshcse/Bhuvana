using System;

namespace Reverse_String_Using_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String Str = Console.ReadLine();
            string res = "";
            for(int i=Str.Length-1;i>=0;i--)
            {
                res += Str[i];
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

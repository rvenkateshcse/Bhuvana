using System;

namespace Remove_Special_Character_Fom_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Str = Console.ReadLine();
            string Res = "";
            foreach(char ch in Str)
            {
                if(ch>=65&&ch<=90||ch>=97&&ch<=122)
                {
                    Res += ch;
                }
            }
            Console.WriteLine(Res);
            Console.ReadLine();
        }
    }
}

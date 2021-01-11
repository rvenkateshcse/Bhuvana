using System;

namespace Convert_String_To_Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            foreach(char ch in str)
            {
                if(ch>=65&&ch<=90)
                {
                    char d = (char)(ch + 32);
                    Console.Write(d);
                }
                else
                {
                    char z = ch;
                    Console.Write(z);
                }
            }
            Console.ReadLine();
        }
    }
}

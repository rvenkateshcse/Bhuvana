using System;

namespace stringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Str = Console.ReadLine();
           for(int i=0;i<Str.Length;i++)
            {
                if (Str[i] == ' ')
                    Console.WriteLine(Str[i]);
                else
                    Console.Write(Str[i]);
            }
            Console.ReadLine();
        }
    }
}

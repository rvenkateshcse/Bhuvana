using System;

namespace Arrange_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            char[] Str = Console.ReadLine().ToCharArray();
            char temp;
            for(int i=1;i<Str.Length;i++)
            {
                for(int j=0;j<Str.Length-1;j++)
                {
                    if(Str[j]>Str[j+1])
                    {
                        temp = Str[j];
                        Str[j] = Str[j+1];
                        Str[j+1] = temp;
                    }
                }
            }
            Console.WriteLine(Str);
            Console.ReadLine();
        }
    }
}

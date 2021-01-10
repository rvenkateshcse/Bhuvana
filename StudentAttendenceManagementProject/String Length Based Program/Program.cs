using System;

namespace String_Length_Based_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            char[] Str = Console.ReadLine().ToCharArray();
            char[] Res=new char[100];
            int Len=0, Reslen = 0;
            foreach(char ch in Str)
            {
                Len += 1;
            }
            if(Len%3==0)
            {
                for(int i=2;i<Len;i+=3)
                {
                    Res[Reslen] += Str[i];
                    Reslen += 1;
                }
                Console.WriteLine(Res);
            }
            else
            {
                Res = Str;
                Console.WriteLine(Str);
            }
            Console.ReadLine();
        }
    }
}

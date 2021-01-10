using System;

namespace Replace_Spaces__In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            char[] str = Console.ReadLine().ToCharArray();
            int spaceCount = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==' ')
                {
                    spaceCount += 1;
                }
            }
            int length = str.Length + (spaceCount*2);
            for(int i=str.Length-1;i>=0;i--)
            {
                if(str[i]==' ')
                {
                    str[length - 1] = '0';
                    str[length - 2] = '2';
                    str[length - 3] = '%';
                    length = length - 3;
                }
                else
                {
                    str[length - 1] = str[i];
                    length = length - 1;
                }
            }
            Console.WriteLine(str);
            Console.ReadLine();
           
            
            
        }
    }
}

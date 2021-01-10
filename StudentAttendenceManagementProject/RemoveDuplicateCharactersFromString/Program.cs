using System;

namespace RemoveDuplicateCharactersFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            char[] Str = Console.ReadLine().ToCharArray();
            int len = Str.Length;
            for(int i=0;i<len;i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if(Str[i]==Str[j])
                    {
                        for (int k = j; k < len - 1; k++)
                        {
                            Str[k] = Str[k + 1];
                        }
                        len -= 1;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(Str[i]);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Remove_Character_From_1st_string_Which_Presented_In_2nd_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String");
            char[] char1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("Enter Second String");
            char[] char2 = Console.ReadLine().ToCharArray();
            int clen = char1.Length;
            for(int i=0;i<char1.Length;i++)
            {
                for(int j=i;j<char2.Length;j++)
                {
                    if(char1[i]==char2[j])
                    {
                        for (int k = 0; k < char1.Length-1; k++)
                        {
                            char1[k] = char1[k + 1];
                        }
                        clen -= 1;
                    }
                }
            }
            for (int i = 0; i < clen; i++)
            {
                Console.Write(char1[i]);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace CheckingTheStringIsAnagramOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter First String");
            string Str1 =Console.ReadLine();
            Console.WriteLine(" Enter Second String");
            string Str2 = Console.ReadLine();
            int length1=0, length2=0,Count=0;
            foreach(char ch in Str1)
            {
                length1 += 1;
            }
            foreach (char ch in Str2)
            {
                length2 += 1;
            }
            if(length1==length2)
            {
                for(int i=0;i<length1;i++)
                {
                    for(int j=0;j<length2;j++)
                    {
                        if(Str1[i]==Str2[j])
                        {
                            Count += 1;
                            break;
                        }
                    }
                }
            }
            if(Count==length1)
            {
                Console.WriteLine(" Strings are anagram");
            }
            else
            {
                Console.WriteLine("Strings are not Anagram");
            }
            Console.ReadLine();
        }
    }
}

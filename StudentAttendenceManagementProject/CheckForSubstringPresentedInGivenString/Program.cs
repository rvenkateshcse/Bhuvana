using System;

namespace CheckForSubstringPresentedInGivenString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Substring");
            string Substr = Convert.ToString(Console.ReadLine());
            int count = 0;
            for(int i=0;i<Substr.Length;i++)
            {
                for(int j=0;j<Str.Length;j++)
                {
                    if(Substr[i]==Str[j])
                    {
                        
                    }
                }
            }
        }
    }
}

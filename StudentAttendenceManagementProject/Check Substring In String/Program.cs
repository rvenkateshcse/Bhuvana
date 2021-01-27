using System;

namespace Check_Substring_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Sub String");
            string substr = Console.ReadLine();
            for(int i=0;i<str.Length;i++)
            {
                int j = 0;
                for( j=0;j<substr.Length;j++)
                {
                    if(str[i+j]!=substr[j])
                    {
                        break;
                    }
                }
                if (j == substr.Length - 1)
                    return i;
               
            }
            Console.ReadLine();
        }
    }
}

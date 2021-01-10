using System;

namespace Check_Two_Strings_Are_Rotation_Of_EachOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String");
            string Str = Convert.ToString(Console.ReadLine());
            string res = "";
            Console.WriteLine("Enter Second String");
            char[] char2 = Console.ReadLine().ToCharArray();
            int count = 0;
            for(int i=Str.Length-1;i>=0;i--)
            {
                res += Str[i];
            }
            char[] char1 = res.ToCharArray();
            if (char1.Length == char2.Length)
            {
                for (int i = 0; i < char1.Length ; i++)
                {
                    for (int j = 0;j<char2.Length;j++)
                    {
                        if (i==j&&char1[i]==char2[j])
                        {
                            count += 1;
                        }
                    }
                }
                
                if (count==char1.Length)
                {
                    Console.WriteLine("Two Strings are Rotation of Each Others");
                }
                else
                {
                    Console.WriteLine("Two Strings are not Rotation of Each Others");
                }
                Console.ReadLine();
            }
        }
    }
}

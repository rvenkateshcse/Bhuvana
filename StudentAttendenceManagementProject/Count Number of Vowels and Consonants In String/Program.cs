using System;

namespace Count_Number_of_Vowels_and_Consonants_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Str = Console.ReadLine();
            int Vowcount = 0, Consonants = 0;
            for(int i=0;i<Str.Length;i++)
            {
                if(Str[i]=='a'|| Str[i] == 'e'|| Str[i] == 'i'|| Str[i] == 'o'|| Str[i] == 'u'|| Str[i] == 'A'|| Str[i] == 'E'|| Str[i] == 'I'||Str[i] == 'O'|| Str[i] == 'U')
                {
                    Vowcount += 1;
                }
                else
                {
                    Consonants += 1;
                }
            }
            Console.WriteLine("The Number Of Vowels In a String : " + Vowcount);
            Console.WriteLine("The Number Of Consonants In a String : " + Consonants);
            Console.ReadLine();

        }
    }
}

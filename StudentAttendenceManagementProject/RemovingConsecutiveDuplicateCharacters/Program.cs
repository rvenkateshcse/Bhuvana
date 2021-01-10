using System;

namespace RemovingConsecutiveDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            char[] Str = Console.ReadLine().ToCharArray();
            string Res = "";
            for (int i = 0; i < Str.Length-1 ; i++)
            {

                if (i == 0)
                {
                    if (Str[i] >= 'a' && Str[i] <= 'z' || Str[i] >= 'A' && Str[i] <= 'Z')

                    {
                        if (Str[i] == Str[i + 1] && ((Str[i] >= 'a' && Str[i] <= 'z') || (Str[i] >= 'A' && Str[i] <= 'z')))
                        {
                            Res += Str[i];

                        }
                        else
                        {
                            Res += Str[i];
                        }
                    }
                    else
                    {
                        Res += Str[i];
                    }
                }
                else
                {
                    if (Str[i]!=Str[i-1] && (Str[i] >= 'a' && Str[i] <= 'z' || Str[i] >= 'A' && Str[i] <= 'Z'))

                    {
                        if (Str[i] == Str[i + 1] && ((Str[i] >= 'a' && Str[i] <= 'z') || (Str[i] >= 'A' && Str[i] <= 'Z')))
                        {
                            Res += Str[i];

                        }
                        else
                        {
                            Res += Str[i];
                        }
                    }

                    else if (Str[i] >='1'&&Str[i]<='9')
                    {
                        Res += Str[i];
                    }

                }
            }

            Console.WriteLine(Res);
            Console.ReadLine();
        }
    }
}



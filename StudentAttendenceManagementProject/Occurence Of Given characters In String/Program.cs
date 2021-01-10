using System;

namespace Occurence_Of_Given_characters_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Str = Console.ReadLine();
            Console.WriteLine("Enter Character To Find its Occurence");
            char Ch = Convert.ToChar(Console.ReadLine());
            
            for(int i=0;i<Str.Length;i++)
            {
                if(Str[i]==Ch)
                {
                    int count = 1;
                    for(int j=i+1;j<Str.Length;j++)
                    {
                        if(Str[i]==Str[j])
                        {
                            count += 1;
                        }
                    }
                    if(count>0)
                    {
                        Console.WriteLine("The Character " + Ch + "  Occurs  " + count + " times");
                        break;
                    }
                }
            }
            Console.ReadLine();
            
        }
    }
}

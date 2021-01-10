using System;

namespace MaximumOccuringCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            int  Maxcount = 0,count=0;
            char Maxchar=' ';
            Console.WriteLine("Enter String");
            string Str = Convert.ToString(Console.ReadLine());
            for(int i=0;i<Str.Length;i++)
            {
                count = 0;
                for(int j=0;j<Str.Length;j++)
                {
                    if(i!=j&&Str[i]==Str[j])
                    {
                        count += 1;
                    }
                }
                if(count>Maxcount)
                {
                    Maxcount = count;
                    Maxchar = Str[i];
                }
            }
            Console.WriteLine(Maxchar);
            Console.ReadLine();
        }
    }
}

using System;

namespace ConvertCharactersToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Input = Convert.ToString(Console.ReadLine());
            string Res = "";
            for(int i=0;i<Input.Length;i++)
            {
                if(Input[i]>='a'&&Input[i]<='z')
                {
                    Res += (char)(Input[i] - 'a' + 'A');
                }
                else
                {
                    Res += Input[i];
                }
            }
            Console.WriteLine(Res);
            Console.ReadLine();
        }
    }
}

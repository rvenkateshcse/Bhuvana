using System;

namespace ConvertUppercaseToLowercase
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
                if(Input[i]>='A'&&Input[i]<='Z')
                {
                    Res += (char)(Input[i] - 'A' + 'a');
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

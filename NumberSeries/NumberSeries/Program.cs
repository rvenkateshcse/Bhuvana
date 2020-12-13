using System;

namespace NumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string Sl = " ";
            string vow = " ";
            string Num = " ";
            string spl = " ";
            Console.WriteLine("Enter Your String");
            str = Convert.ToString(Console.ReadLine());
            foreach(char ch in str)
            {
                if(char.IsLower(ch))
                {
                    Sl += ch;
                }
            else  if(ch=='a'|| ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' )
                {
                    vow += ch;
                }
                else if(char.IsDigit(ch))
                {
                    Num += ch;
                }
                else 
                {
                    spl += ch;
                }
            }
            Console.WriteLine(Sl);
            Console.WriteLine(vow);
            Console.WriteLine(Num);
            Console.WriteLine(spl);
            Console.ReadLine();
        }
    }
}

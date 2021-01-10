using System;

namespace Count_Number_Of_Digits_From_a_Given_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            while(Num>0)
            {
                count += 1;
                Num /= 10;
            }
            Console.WriteLine(Num.ToString().ToCharArray().Length);
            Console.ReadLine();
        }
    }
}

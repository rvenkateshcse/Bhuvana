using System;

namespace Power_of_four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int Num = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            while(res<Num)
            {
                res *= 4;
            }
            if (res == Num)
            
                Console.WriteLine("yes");
            
            else
                Console.WriteLine("no");
            Console.ReadLine();
        }
    }
}

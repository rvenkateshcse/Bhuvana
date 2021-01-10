using System;

namespace Lcm_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int gcd = 1;
            for (int i = 2; i <= n1 && i <= n2; i++)
            {
                if(n1%i==0&&n2%i==0)
                {
                     gcd = i;
                }
            }
            int Lcm = (n1 * n2) / gcd;
            Console.WriteLine(Lcm);
            Console.ReadLine();
        }
    }
}

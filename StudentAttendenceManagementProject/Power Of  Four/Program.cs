using System;

namespace Power_Of__Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            bool flag=true;
            for(int i=0;i<=Num;i++)
            {
                 
                if (Num == (4 ^ i))
                {
                    flag = false;
                    break;
                }
               
            }
            if(flag)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }

            Console.ReadLine();
        }
    }
}

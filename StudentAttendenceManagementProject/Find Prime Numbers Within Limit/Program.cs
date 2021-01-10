using System;

namespace Find_Prime_Numbers_Within_Limit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Maximum Index");
            int MaxIndex = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= MaxIndex; i++)
            {
                int count = 0;
                for (int j = 2; j <=MaxIndex; j++)
                {
                    if (i!=j&&i%j==0)
                    {
                        count += 1;
                    }
                }
                if (count == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}

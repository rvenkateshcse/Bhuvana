using System;

namespace Happy_Number
{
    class Program
    {
        public static int HappyNumber(int Num)
        {
            int Rem = 0, Sum = 0;
            while (Num > 0)
            {
                Rem = Num % 10;
                Sum+=Rem*Rem;
                Num /= 10;
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                int Result = i;
                while (Result != 1 && Result != 4)
                {
                    Result = HappyNumber(Result);
                }
                if (Result == 1)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

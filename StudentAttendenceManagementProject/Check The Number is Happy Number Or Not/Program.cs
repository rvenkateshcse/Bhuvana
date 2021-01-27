using System;

namespace Check_The_Number_is_Happy_Number_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int Number = Convert.ToInt32(Console.ReadLine());
           for(int i=1;i<=Number;i++)
            {
                int Rem = 0, Sum = 0, Square = 0;
                if(i==1)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Square = i * i;
                    if (Square > 9)
                    {
                        while (Square > 9)
                        {
                            Rem = Square%10;
                            Sum = Sum + (Rem * Rem);
                            Square /= 10;
                            if (Square == 0 && Sum > 9)
                            {
                                Square = Sum;
                                Sum = 0;
                            }
                            else if(Sum==1)
                            {
                                Console.Write(i);
                            }
                        }
                    }
                }
            }
            Console.ReadLine();

        }
    }
}

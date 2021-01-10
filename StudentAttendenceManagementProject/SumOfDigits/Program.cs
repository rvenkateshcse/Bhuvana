using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];
            int temp;
            Console.WriteLine("Enter Your Elements");
            for (int i = 0; i < Size; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            for (int j = 0; j <= Size - 2; j++)
            {
                for (int i = 0; i <= Size - 2; i++)
                {
                    if (Array[i] < Array[i + 1])
                    {
                        temp = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine("         ");
            for (int i = 0; i < Size; i++)
            {
                int sum = 0;
                if (Array[i] > 9)
                {
                    int num = Array[i];
                    sum = 0;
                    while (num > 0)
                    {
                        sum = sum + num % 10;
                        num = num / 10;
                    }
                }
                bool flag = false;
                for (int j = i + 1; j < Size; j++)
                {
                    if (sum == Array[j])
                    {
                        flag = true;
                        Console.WriteLine(+Array[i] + "  = " + Array[j]);
                        Console.WriteLine("--------");
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < Size; j++)
                    {
                        if (sum > 9)
                        {
                            int num2 = sum;
                            int sum2 = 0;
                            while (num2 > 0)
                            {
                                sum2 = sum2 + num2 % 10;
                                num2 = num2 / 10;
                            }
                            for (int k = 0; k < Size; k++)
                            {
                                if (sum2 == Array[k])
                                {
                                    Console.WriteLine(+Array[i] + "  = " + Array[k]);
                                    Console.WriteLine("--------");
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }

            }
          
            Console.ReadLine();
            

        }
    }
}

using System;

namespace Maximum_And_Minimum_Value_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<Size;i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int j = 0; j <= Size - 2; j++)
            {
                for (int i = 0; i <= Size - 2; i++)
                {
                    if (Array[i] < Array[i + 1])
                    {
                        temp = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = temp;
                    }
                }
            }
            for (int i=0;i<Size;i++)
            {
                if(i==0)
                {
                    Console.WriteLine("The Maximum Number in Array is : " + Array[i]);
                }
               if (i == Size-1)
                {
                    Console.WriteLine("The Minimum Number in Array is : " + Array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}

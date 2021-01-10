using System;
using System.Linq;

namespace Sorting_Array_in_Ascending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];
            Console.WriteLine("Enter Array Elements");
            int temp;
            for(int i=0;i<Size;i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0;j<=Size-2;j++)
            {
                for (int i = 0; i <=Size-2; i++)
                {
                    if (Array[i] >Array[i + 1])
                    {
                        temp = Array[i+1];
                        Array[i+1] = Array[i];
                        Array[i] = temp;

                    }
                }
            }
            Console.WriteLine("--------");

            for (int i=0;i<Size;i++)
            {
                Console.WriteLine(Array[i]);
            }
        Console.ReadLine();
        }
    }
}

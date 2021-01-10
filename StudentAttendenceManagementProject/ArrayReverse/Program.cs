using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array Elements");
            int[] Array = new int[Size];
            for(int i=0;i<Size;i++)
            {
                Array[i] =Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine("--------");
            for(int i=Size-1;i>=0;i--)
            {
                Console.WriteLine(Array[i]);
            }
            Console.ReadLine();
        }
    }
}

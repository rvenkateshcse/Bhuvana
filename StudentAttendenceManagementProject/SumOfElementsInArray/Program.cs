using System;

namespace SumOfElementsInArray
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
            int Sum = 0;
            for(int i=0;i<Size;i++)
            {
                Sum += Array[i];
            }
            Console.WriteLine("The Sum of Array Elements Is : " + Sum);
            Console.ReadLine();
        }
    }
}

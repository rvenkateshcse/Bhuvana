using System;

namespace Copy_The_Elements_From_One_Array_To_Another
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array1 = new int[Size];
            int[] Array2 = new int[Size];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<Size;i++)
            {
                Array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<Size;i++)
            {
                Array2[i] = Array1[i];
            }
            Console.WriteLine("The Second Array Elements Are : ");
            for(int i=0;i<Size;i++)
            {
                Console.WriteLine(Array2[i]);
            }
            Console.ReadLine();
        }
    }
}

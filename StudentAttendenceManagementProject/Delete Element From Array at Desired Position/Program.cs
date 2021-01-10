using System;

namespace Delete_Element_From_Array_at_Desired_Position
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
           
            Console.WriteLine("Enter Position To Delete Element");
            int Pos = Convert.ToInt32(Console.ReadLine());
            
            for (int i = Pos-1; i < Size-1; i++)
            {

                Array[i] = Array[i + 1];
            }
            Console.WriteLine("----");
            for(int i=0;i<Size-1;i++)
            {
                Console.WriteLine(Array[i]);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Second_Largest_Element_In_Array
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
            int lrg = 0, seclrg = 0;
           
            for(int i=0;i<Size;i++)
            {
              if(Array[i]>lrg)
                {
                    seclrg = lrg;
                    lrg = Array[i];
                }
              else if(Array[i]>seclrg&&Array[i]<lrg)
                {
                    seclrg = Array[i];
                }
            }
            Console.WriteLine("---");
            Console.WriteLine(seclrg);
            Console.ReadLine();
        }
    }
}

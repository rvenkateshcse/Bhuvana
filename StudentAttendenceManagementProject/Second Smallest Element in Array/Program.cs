using System;

namespace Second_Smallest_Element_in_Array
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
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sml=Array[0], secsml = Array[0]; 
            for(int i=1;i<Size;i++)
            {
                if(Array[i]<sml)
                {
                    secsml = sml;
                    sml = Array[i];
                }
              else  if(Array[i]<secsml&&Array[i]!=sml)
                {
                    secsml = Array[i];
                }
               
            }
            Console.WriteLine("---");
            Console.WriteLine(secsml);
            Console.ReadLine();
        }
    }
}

using System;

namespace DuplicateElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int Size;
            Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];
            Console.WriteLine("Enter Your Elements");
            for(int i=0;i<Size;i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---------------");
          
            for(int i=0;i<Size;i++)
            {
                int count = 1;
               
                for (int j = i + 1; j < Size; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        count += 1;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine("The Number  " + Array[i] + "   occurs    " + count + "  Times");
                }
            }
           
            Console.ReadLine();
        }
    }
}

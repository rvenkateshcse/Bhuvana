using System;

namespace Number_Of_Duplicate_Elements_In_Array
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
            Console.WriteLine("---------");
            int count = 0;
            for (int i=0; i<Size;i++)
            {
               
                for (int j=i+1;j<Size;j++)
                {
                    if(Array[i]==Array[j])
                    {
                        count += 1;
                        break;
                    }
                }
                
            }
            Console.WriteLine(count);
           
            Console.ReadLine();

        }
    }
}

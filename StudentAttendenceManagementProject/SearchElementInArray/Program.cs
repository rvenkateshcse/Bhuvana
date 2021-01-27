using System;

namespace SearchElementInArray
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
            Console.WriteLine("Enter Element to Search");
         int Element=Convert.ToInt32 (Console.ReadLine());
            bool flag = true;
            int Pos = 0;
            for(int i=0;i<Size;i++)
            {
                if(Array[i]==Element)
                {
                    flag = false;
                    Pos = i;  
                    break;
                }
            }
            if (flag)
                Console.WriteLine("The {0} Does not Present In Array ", Element);
            else
                Console.WriteLine("The {0} Present In Array at {1} Position ", Element,Pos);

            Console.ReadLine();
        }
    }
}

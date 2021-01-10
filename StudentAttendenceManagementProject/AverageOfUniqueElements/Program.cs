using System;

namespace AverageOfUniqueElements
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
            int Avg = 0, Count = 0,Sum=0;
            int[] ResultArray = new int[Size];
            for(int i=0;i<Size;i++)
            {
                bool flag = false;
                for(int j=0;j<Size;j++)
                {
                    if(i!=j&&Array[i]==Array[j])
                    {
                        flag = true;
                    }
                }
                if(!flag)
                {
                    ResultArray[i] += Array[i];
                    Count += 1;
                }
            }
            for(int i=0;i<ResultArray.Length;i++)
            {
                Sum += ResultArray[i];
            }
            if (Sum != 0 && Count != 0)
            {
                Avg = Sum / Count;
                Console.WriteLine(Avg);
            }
            else
            {
                Console.WriteLine("The Array Does Not Contains Unique Element");
            }
            Console.ReadLine();
        }
    }
}

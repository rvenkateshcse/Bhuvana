using System;

namespace Average_Of_Array_Elements_Without_Max_And_Min_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array Elements");
            int[] Array = new int[Size];
            int  temp=0;
            for(int i=0;i<Size;i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j <= Size - 2; j++)
            {
                for (int i = 0; i <= Size - 2; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        temp = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = temp;

                    }
                }
            }
            int sum = 0,Avg = 0,count=0,max=0,min=0;
            for(int i=0;i<Size;i++)
            {
                if(i==0)
                {
                    min = Array[i];
                }
                else if(i==Size-1)
                {
                    max = Array[i];
                }
            }
            for(int i=0;i<Size;i++)
            {
                if(Array[i]!=max&&Array[i]!=min)
                {
                    sum += Array[i];
                    count += 1;
                }
            }
            Console.WriteLine("-----");
            if(sum!=0)
            {
                Avg = sum / count;
                Console.WriteLine(Avg);
            }
            Console.ReadLine();

        }
    }
}

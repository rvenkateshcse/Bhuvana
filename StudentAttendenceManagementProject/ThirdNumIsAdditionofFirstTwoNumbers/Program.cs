using System;

namespace ThirdNumIsAdditionofFirstTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Array Size");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[Size];
            int temp;
            for (int i = 0; i < Size; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            Console.WriteLine("----");
            for (int j = 0; j <= Size - 2; j++)
            {
                for (int i = 0; i <= Size - 2; i++)
                {
                    if (Arr[i] > Arr[i + 1])
                    {
                        temp = Arr[i + 1];
                        Arr[i + 1] = Arr[i];
                        Arr[i] = temp;
                    }
                }
            }
            for(int i=0;i<Size;i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.WriteLine("----");
            for (int i=0;i<Size-2;i++)
            {
                for(int j=i+1;j<Size-1;j++)
                {
                    for (int k = j+1; k < Size; k++)
                    {
                        if (Arr[i] + Arr[j] == Arr[k])
                        {
                            Console.WriteLine(Arr[i]);
                            Console.WriteLine(Arr[j]);
                            Console.WriteLine(Arr[k]);
                            Console.WriteLine("------");
                            
                        }
                   
                    } 
                }
            }
            Console.ReadLine();
        }
    }
}

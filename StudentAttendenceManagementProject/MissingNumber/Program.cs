using System;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size;
            Size = Convert.ToInt32(Console.ReadLine());
           
            int[] Arr = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----");
            bool flag;
            for (int i= 1; i <= Size; i++)
            {
                flag = false;
                for (int j = 0; j < Size; j++)
                {
                     if(i==Arr[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine(i);
                }
               
            }
            Console.ReadLine();
        }
        
    }
}

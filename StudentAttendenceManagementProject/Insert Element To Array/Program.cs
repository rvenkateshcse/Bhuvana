using System;

namespace Insert_Element_To_Array
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
            int[] NewArr = new int[Size + 1];
            Console.WriteLine("Enter Position");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number To Insert");
            int num = Convert.ToInt32(Console.ReadLine());
            int Newlen = 0;
            for(int i=0;i<NewArr.Length;i++)
            {
                if(i<=pos-2)
                {
                    NewArr[i] = Array[i];
                    
                }
                else if(i==pos-1)
                {
                    NewArr[i] = num;
                   
                }
                else 
                {
                     NewArr[i] = Array[i-1];
                        
                    
                }
            }
            Console.WriteLine("------");
            for(int i=0;i<NewArr.Length;i++)
            {
                Console.WriteLine(NewArr[i]);
            }
            Console.ReadLine();
            
        }
    }
}

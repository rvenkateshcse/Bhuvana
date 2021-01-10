using System;

namespace print_Identity_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size");
            int order = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<order;i++)
            {
                for(int j=0;j<order;j++)
                {
                    if(i==j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}

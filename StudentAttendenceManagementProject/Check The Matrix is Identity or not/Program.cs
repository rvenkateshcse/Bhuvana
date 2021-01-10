using System;

namespace Check_The_Matrix_is_Identity_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter order");
            int order = Convert.ToInt32(Console.ReadLine());
            int[,] Array = new int[order,order];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<order;i++)
            {
                for(int j=0;j<order;j++)
                {
                    Array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    if ((Array[i, j] != 1 && i == j) || Array[i, j] != 0 && i != j)
                        goto conclusion;
                }
            }
            Console.WriteLine("Identity Matrix");
            return;
        conclusion:
            Console.WriteLine("Not Identity Matrix");
            Console.ReadLine();
        }
    }
}

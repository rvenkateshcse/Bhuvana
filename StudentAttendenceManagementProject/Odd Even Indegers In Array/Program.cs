using System;

namespace Odd_Even_Indegers_In_Array
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Array Size");
			int Size = Convert.ToInt32(Console.ReadLine());
			int[] Array = new int[Size];
			Console.WriteLine("Enter Array Elements");
			for (int a = 0; a < Size; a++)
			{
				Array[a] = Convert.ToInt32(Console.ReadLine());
			}
			int[] OddArray = new int[Size] ;
			int[] EvenArray = new int[Size] ;
			int i = 0, j = 0, num = 0;
			for (int a = 0; a < Size; a++)
			{
				num = Array[a]; ;
				if (num % 2 == 0)
				{
					EvenArray[i] = num;
					i++;
				}
				else
				{
					OddArray[j] = num;
					j++;
				}
			}
			if (EvenArray.Length != 0)
			{
				Console.WriteLine("The Even Integers In Array : ");
				for (int a = 0; a < EvenArray.Length; a++)
				{
					Console.WriteLine(EvenArray[a]);
				}
			}
			if (OddArray.Length != 0)
			{
				Console.WriteLine("The Odd Integers In Array : ");
				for (int a = 0; a < OddArray.Length; a++)
				{
					Console.WriteLine(OddArray[a]);
				}
			}
		}
    }
}

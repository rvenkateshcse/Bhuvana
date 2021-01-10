using System;

namespace Print_Unique_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Array size");
			int Size = Convert.ToInt32(Console.ReadLine());
			int[] Array = new int[Size];
			Console.WriteLine("Enter Array Elements");
			for (int i = 0; i < Size; i++)
			{
				Array[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("----");
			for (int i = 0; i < Size; i++)
			{
				bool flag = true;
				for (int j = 0; j < Size; j++)
				{
					if (Array[i] == Array[j] && i != j)
					{
						flag = false;
					}
				}
				if (flag)
				{
					Console.WriteLine(Array[i]);
				}
			}
		}
	}
}


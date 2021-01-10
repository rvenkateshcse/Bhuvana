using System;

namespace Array_Reverse_Using_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter String");
			string str = Console.ReadLine();
			string Res = Reverse(str);
			Console.WriteLine(Res);
		}
		static string Reverse(string str)
		{
			if (str.Length == 1)
			{
				return str;
			}
			else
			{
				return str[str.Length - 1] + Reverse(str.Substring(0, str.Length - 1));
			}
		}
    }
}

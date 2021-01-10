using System;

namespace String_Permutation
{
    class Program
    {
     static  string Swap(string Str,int pos1,int pos2)
     {
            char[] a = Str.ToCharArray();
            char b;
            b = a[pos1];
            a[pos1] = a[pos2];
            a[pos2] = b;

            return new string(a);
     }
     public static void Main()
        {
            string str = Console.ReadLine();
            int len = str.Length;
            Permutation(str, 0, len-1);
        }
        static void Permutation(string str,int start,int end)
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for(int i=start;i<=end;i++)
                {
                    str = Swap(str, start,i) ;
                    Permutation(str, start +1, end);
                    str = Swap(str, start, i);
                }
            }

        }
       
    }
}

using System;

namespace FirstNonRepeatedCharacterFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string Str = Convert.ToString(Console.ReadLine());
            int length = 0,count=0;
            foreach(char c in Str)
            {
                length += 1;
            }
            
            for(int i=0;i<length;i++)
            {
                bool flag = false;
                for (int j=0;j<length;j++)
                {
                    if(i!=j&&Str[i]==Str[j])
                    {
                        flag = true;
                        break;
                    }
                  
                }
                if(!flag)
                {
                    Console.WriteLine(Str[i]);
                    count += 1;
                    break;
                }
            }
            if(count==0)
            {
                Console.WriteLine("The String Does Not Contains Repeated Characters");
            }
            Console.ReadLine();
        }
    }
}

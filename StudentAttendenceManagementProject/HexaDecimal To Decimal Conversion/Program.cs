using System;

namespace HexValueaDecimal_To_Decimal_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HexValue Number");
            string HexValue = Console.ReadLine();
            int val = 0, Base1 = 1;
            int len = HexValue.Length;
            for (int i = len -1; i >= 0; i--)
            {
                if (HexValue[i] >= '0' && HexValue[i] <= '9')
                {
                    val += (HexValue[i] - 48) * Base1;
                    Base1 *= 16;
                }
                else if (HexValue[i] >= 'A' && HexValue[i] <= 'F')
                {
                    val += (HexValue[i] - 55) * Base1;
                    Base1 *= 16;
                }
                else if (HexValue[i] >= 'a' && HexValue[i] <= 'f')
                {
                    val += (HexValue[i] - 87) * Base1;
                    Base1 *= 16;
                }
            }
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }
}

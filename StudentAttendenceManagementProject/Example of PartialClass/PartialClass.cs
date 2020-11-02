using System;
using System.Collections.Generic;
using System.Text;

namespace Example_of_PartialClass
{
    public partial class PartialClass
    {
        public void Display(string Name)
        {
            Console.WriteLine("Person Name is:", Name);
        }
    }
    public partial class PartialClass
    {
        public void Details(int Age, string Education)
        {
            Console.WriteLine("Person Age and Education  is:", Age, Education);
        }
    }
    public class Test
    {
   public void Main()
    {
        PartialClass Pc = new PartialClass();
        Pc.Display("Kaviya");
        Pc.Details(21, "BE");
    }
}
}

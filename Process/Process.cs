using Maths;
using System;
using System.Collections.Generic;
using System.Text;

namespace Process
{
    public class ProcessInput
    {
        public string Process(string input1,string input2,string input3)
        {
            string output = string.Empty;
            switch(input3)
            {
                case "add":
                    output = Addition.Add(input1,input2).ToString();
                    break;
                case "subtraction":
                    output = Subtraction.sub(input1, input2).ToString();
                    break;
                case "multiplication":
                    output = Multiplication.mul(input1, input2).ToString();
                    break;
                case "division":
                    output = Division.div(input1, input2).ToString();
                    break;


            }
            return output;
            }
    }
}

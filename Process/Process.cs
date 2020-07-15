using Maths;
using Numbers;
using LoginForms;

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
                case "divby3notby6":
                    output = Divisionbythreenotbysix.Run(input1).ToString();
                    break;
                case "armstrongornot":
                    output = armstrongnumber.check(input1).ToString();
                    break;
                case "factorial":
                    output = Factorial.calculate(input1).ToString();
                    break;
                case "palindrome":
                    output = PalindromeNumber.find(input1).ToString();
                    break;
                case "reverse":
                    output = ReverseNumber.Reverse(input1).ToString();
                    break;
                case "login":
                    output = LoginClass.Login(input1, input2).ToString();
                    break;
                case "sumofdigits":
                    output = Sumofdigits.find(input1).ToString();
                    break;

            }
            return output;
        }
    }
}

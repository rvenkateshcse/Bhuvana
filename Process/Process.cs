using Maths;
using Numbers;
using LoginForms;
using StringFunctions;

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
                case "decimaltobinary":
                    output = DecimaltoBinary.convert(input1).ToString();
                    break;
                case "numberincharacter":
                    output = NumbersInCharacters.print(input1).ToString();
                    break;
                case "strreverse":
                    output = StringReverse.Reverse(input1).ToString();
                    break;
                case "duplicate":
                    output = DuplicateElement.find(input1).ToString();
                    break;
                case "unique":
                    output = UniqueElement.Return(input1).ToString();
                    break;
                case "strpalindrome":
                    output = StringPalindrome.find(input1).ToString();
                    break;
                case "length":
                    output = StringLength.calculate(input1).ToString();
                    break;
                case "vowels":
                    output = NumofVowels.print(input1).ToString();
                    break;
                case "search":
                    output = CharacterSearching.search(input1, input2).ToString();
                    break;
                case "count":
                    output = WordCount.count(input1).ToString();
                    break;
                case "replace":
                    output = CharacterReplace.Replace(input1, input2).ToString();
                    break;



            }
            return output;
        }
    }
}

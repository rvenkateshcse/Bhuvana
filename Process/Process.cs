using Maths;
using Numbers;
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
                    output = Subtraction.Sub(input1, input2).ToString();
                    break;
                case "multiplication":
                    output = Multiplication.Mul(input1, input2).ToString();
                    break;
                case "division":
                    output = Division.Div(input1, input2).ToString();
                    break;
                case "divby3notby6":
                    output = Divisionbythreenotbysix.Run(input1).ToString();
                    break;
                case "armstrongornot":
                    output = Armstrongnumber.Check(input1).ToString();
                    break;
                case "factorial":
                    output = Factorial.Calculate(input1).ToString();
                    break;
                case "palindrome":
                    output = PalindromeNumber.Find(input1).ToString();
                    break;
                case "reverse":
                    output = ReverseNumber.Reverse(input1).ToString();
                    break;
                case "sumofdigits":
                    output = Sumofdigits.Find(input1).ToString();
                    break;
                case "decimaltobinary":
                    output = DecimaltoBinary.Converts(input1).ToString();
                    break;
                case "numberincharacter":
                    output = NumbersInCharacters.Print(input1).ToString();
                    break;
                case "strreverse":
                    output = StringReverse.Reverse(input1).ToString();
                    break;
                case "duplicate":
                    output = DuplicateElement.Find(input1).ToString();
                    break;
                case "unique":
                    output = UniqueElement.Return(input1).ToString();
                    break;
                case "strpalindrome":
                    output = StringPalindrome.Find(input1).ToString();
                    break;
                case "length":
                    output = StringLength.Calculate(input1).ToString();
                    break;
                case "vowels":
                    output = NumofVowels.Print(input1).ToString();
                    break;
                case "search":
                    output = CharacterSearching.Search(input1, input2).ToString();
                    break;
                case "count":
                    output = WordCount.Count(input1).ToString();
                    break;
                case "date":
                    output = DateandTime.Calculate(input1).ToString();
                    break;




            }
            return output;
        }
    }
}

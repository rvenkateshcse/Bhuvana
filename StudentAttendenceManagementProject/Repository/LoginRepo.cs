using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Repository
{
    public static class LoginRepo
    {
        public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        public static SqlConnection con = new SqlConnection(constr);

        public static int Login(string Un, string pd)
        {
            int Res;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentAttendanceTable where UserName='" + Un + "' and  Password='" + pd + "' ", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Res = 1;
            }
            else
            {
                Res = 0;
            }
            con.Close();
            return Res;
        }

        public static int Register(string Sn, string Un, string pd)
        {
            int Res;
            if ((string.IsNullOrEmpty(Un)) || (string.IsNullOrEmpty(pd)))
            {
                Res = 0;
                return Res;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into  StudentAttendanceTable( StudentName , UserName , Password ) values  ('" + Sn + "' , '" + Un + "' , '" + pd + "')  ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return 1;
        }

        public static int Staff(string Sn, int Ad)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update  StudentAttendanceTable set AttendedDays='" + Ad + "' where StudentName='" + Sn + "' ", con);
            cmd.Parameters.AddWithValue("AttendedDays", Ad);
            cmd.ExecuteNonQuery();
            con.Close();
            return 1;
        }

        public static string Student(string Sn)
        {
            string Res = " ";
            con.Open();
            SqlCommand cmd = new SqlCommand("select AttendedDays from StudentAttendanceTable where StudentName='" + Sn + "' ", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Res = sdr.GetValue(0).ToString();
            }
            con.Close();
            return Res;
        }
        public static string StringReverse(string Input1)
        {
            int len = Input1.Length - 1;
            string re = " ";
           for(int i=len;i>=0;i--)
            {
                re += Input1[i];
            }
            return re;
        }
        public static string StringPalindrome(string Input1)
        {
            int len = Input1.Length - 1;
            string re = "";
            string Ans= "";
            for (int i = len; i >= 0; i--)
            {
                re += Input1[i];
            }
            if (re==Input1)
            {
                Ans = "Your string is Palindrome";
            }
          else
            { 
                Ans = "Your string is not Palindrome";
            }
            return Ans;
        }
        public static int StringLength(string Input1)
        {
            int len = 0;
           foreach(char c in Input1)
            { 
                len += 1;
            }
            return len;
        }
        public static string IndividualcharactersInString(string Input1)
        {
            string res = "";
            for(int i=0;i<Input1.Length;i++)
            {
                res += Input1[i] + " ";
            }
            return res;
        }
        public static string IndividualcharactersOfStringInReverseOrder(string Input1)
        {
            int len = Input1.Length - 1;
            string re = " ";
            string res = "";
            for (int i = len; i >= 0; i--)
            {
                re += Input1[i];
            }
           
            for (int i = 0; i < re.Length; i++)
            {
                res += re[i] + " ";
            }
            return res;
        }
        public static int NumberOfWordsInString(string Input1)
        {
            int word = 1;
            for(int i=0;i<Input1.Length;i++)
            {
                if((Input1[i]==' ')||(Input1[i]=='\n'))
                {
                    word++;
                }
            }
            return word;
        }
        public static string CompareTwoStrings(string Input1,string Input2)
        {
            int len1=0, len2=0;
            string res = "";
           foreach(char c in Input1)
            {
                len1+= 1;
            }
            foreach (char c in Input2)
            {
                len2 += 1;
            }
            if(len1==len2)
            {
                res = "Two Input Strings are equal";
            }
            else
            {
                res = "Two Input Strings are not equal";
            }
            return res;
        }
        public static string NumberOfAlaphabetsandVowels(string Input1)
        {
            int Alp = 0, Vow = 0;
            string res = "";
            for(int i=0;i<Input1.Length;i++)
            {
                if((Input1[i]>='a')&&(Input1[i]<='z')||(Input1[i] >= 'A') && (Input1[i] <= 'Z'))
                {
                    Alp += 1;
                }
                if ((Input1[i] == 'a') || (Input1[i] == 'e') || (Input1[i] == 'i') || (Input1[i] == 'o')||(Input1[i] == 'u') || (Input1[i] == 'A') || (Input1[i] == 'E') || (Input1[i] == 'I') || (Input1[i] == 'O') || (Input1[i] == 'U'))
                {
                    Vow += 1;
                }
            }
            res="The No.of Alphabets and Vowels Present In a string is: " +Alp +Vow;
            return res;

        }
        public static string StringCopy(string Input1)
        {
            string res = "";
            for (int i = 0; i < Input1.Length; i++)
            {
                res += Input1[i];
            }
            return res;

        }
        public static int Factorial(int Input1)
        {
            int re = 1;
           while(Input1>=1)
            {
                re = re * Input1;
                Input1--;
            }
            return re;

        }
        public static int SumOfDigits(int Input1)
        {
            int rem, sum=0;
            while(Input1>0)
            {
                rem = Input1 % 10;
                sum = sum + rem;
                Input1 /= 10;
            }
            return sum;
        }
        public static int ReverseNumber(int Input1)
        {
            int rev=0, rem;
           while(Input1>0)
            {
                rem = Input1 % 10;
                rev = rev * 10 + rem;
                Input1 /= 10;
            }
            return rev;
        }
        public static string Palindrome(int Input1)
        {
            int temp = Input1;
            int rev = 0, rem;
            string res = " ";
            while (Input1 > 0)
            {
                rem = Input1 % 10;
                rev = rev * 10 + rem;
                Input1 /= 10;
            }
            if (temp == rev)
                res = "Input Number is Palindrome";
            else
                res = "Input Number is not  Palindrome";

            return res;

        }
        public static string ArmstrongNumber(int Input1)
        {
            int temp = Input1;
            int res = 0, rem;
            string re = " ";
            while (Input1 > 0)
            {
                rem = Input1 % 10;
                res = rem * rem*rem + res;
                Input1 /= 10;
            }
            if (temp == res)
                re = "Input is Armstrong Num ";
            else
                re = "Input is not Armstrong Num";

            return re;

        }
        
    }
}

     
       
        
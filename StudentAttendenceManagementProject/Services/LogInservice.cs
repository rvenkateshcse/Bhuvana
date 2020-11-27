using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class LogInservice
    {
        public static  int Login(string Un, string pd)
        { 
            int re= Repository.LoginRepo. Login(Un, pd);
            return re;
        }
        public static int Register(string Sn, string Un, string Pd)
        {
           
            int re = Repository.LoginRepo.Register(Sn, Un, Pd);
            return re;
        }
        public static int Staff(string Sn, int Ad)
        {
            
            int re = Repository.LoginRepo.Staff(Sn, Ad);
            return re;
        }
        public static string Student(string Sn)
        {
           
            string re = Repository.LoginRepo.Student(Sn);
            return re;
        }
        public static string StringReverse(string Input1)
        {
            string re = Repository.LoginRepo.StringReverse(Input1);
            return re;
        }
        public static string StringPalindrome(string Input1)
        {
            string re = Repository.LoginRepo.StringPalindrome(Input1);
            return re;
        }
        public static int StringLength(string Input1)
        {
            int re = Repository.LoginRepo.StringLength(Input1);
            return re;
        }
        public static string IndividualcharactersInString(string Input1)
        {
            string re = Repository.LoginRepo.IndividualcharactersInString(Input1);
            return re;
        }
        public static string IndividualcharactersOfStringInReverseOrder(string Input1)
        {
            string re = Repository.LoginRepo.IndividualcharactersOfStringInReverseOrder(Input1);
            return re;
        }
        public static int NumberOfWordsInString(string Input1)
        {
           int re = Repository.LoginRepo.NumberOfWordsInString(Input1);
            return re;
        }
        public static string CompareTwoStrings(string Input1,string Input2)
        {
            string re = Repository.LoginRepo.CompareTwoStrings(Input1,Input2);
            return re;
        }
        public static string NumberOfAlaphabetsandVowels (string Input1)
        {
            string re = Repository.LoginRepo.NumberOfAlaphabetsandVowels(Input1);
            return re;
        }
        public static string StringCopy(string Input1)
        {
            string re = Repository.LoginRepo.StringCopy(Input1);
            return re;
        }
        public static int Factorial(int Input1)
        {
            int re = Repository.LoginRepo.Factorial(Input1);
            return re;
        }
        public static int SumOfDigits(int Input1)
        {
            int re = Repository.LoginRepo.SumOfDigits(Input1);
            return re;
        }
        public static int ReverseNumber(int Input1)
        {
            int re = Repository.LoginRepo.ReverseNumber(Input1);
            return re;
        }
        public static string Palindrome(int Input1)
        {
            string re = Repository.LoginRepo.Palindrome(Input1);
            return re;
        }
        public static string ArmstrongNumber(int Input1)
        {
            string re = Repository.LoginRepo.ArmstrongNumber(Input1);
            return re;
        }



    }
}

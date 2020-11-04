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
    }
}

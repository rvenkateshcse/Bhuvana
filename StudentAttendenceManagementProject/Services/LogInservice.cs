using Repository;
using System;
using System.Collections.Generic;
using System.Text;



namespace Services
{
    public class LogInservice
    {
        public static int Login(string Un, string pd)
        {
            int re =Repository.LoginRepo.Login(Un,pd);
            return re;
        }
        public static int Register(string Sn,string Un,string Pd)
        {
            int Re =LoginRepo.Register(Sn, Un, Pd);
            return Re;
        }
        public static int Staff(string Sn, int Ad)
        {
            int Re =LoginRepo.Staff(Sn, Ad);
            return Re;
        }
        public static string Student(string Sn)
        {
            string Re = LoginRepo.Student(Sn);
            return Re;
        }
    }
}

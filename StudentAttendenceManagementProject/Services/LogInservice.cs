using Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace Services
{
    public class LogInservice
    {
        public static int Login(string Un, string pd, string Role)
        {
            int re =Repository.LoginRepo.Login(Un,pd,Role);
            return re;
        }
        public static int Register(string Sn,string Un,string Pd)
        {
            int Re =Repository.LoginRepo.Register(Sn, Un, Pd);
            return Re;
        }
        public static int Staff(string Sn, int Ad)
        {
            int Re =Repository.LoginRepo.Staff(Sn, Ad);
            return Re;
        }
        public static int Student(string Sn)
        {
            int Re = Repository.LoginRepo.Staff(Sn);
            return Re;
        }
    }
}

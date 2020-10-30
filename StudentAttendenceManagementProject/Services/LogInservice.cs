using Repository;
using System;
using System.Collections.Generic;
using System.Text;




namespace Services
{
    public  class LogInservice
    {
        public  int Login(string Un, string pd)
        {
            LogInservice logInservice = new LogInservice();
            int re= logInservice. Login(Un, pd);
            return re;
        }
        public int Register(string Sn, string Un, string Pd)
        {
            LogInservice logInservice = new LogInservice();
            int re = logInservice.Register(Sn, Un, Pd);
            return re;
        }
        public int Staff(string Sn, int Ad)
        {
            LogInservice logInservice = new LogInservice();
            int re = logInservice.Staff(Sn, Ad);
            return re;
        }
        public string Student(string Sn)
        {
            LogInservice logInservice = new LogInservice();
            string re = logInservice.Student(Sn);
            return re;
        }
    }
}

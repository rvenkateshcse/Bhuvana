﻿using System;
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

    }
}

     
       
        
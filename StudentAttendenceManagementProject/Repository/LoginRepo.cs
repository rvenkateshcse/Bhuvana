﻿using System;
using System.Web;
using System.Data.SqlClient;

namespace Repository
{
    public static class LoginRepo
    {
        public static int Login(string Un, string pd)
        {
            int Res;
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
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

            return Res;

        }
        public static int Register(string Sn, string Un, string pd)
        {
            
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into  StudentAttendanceTable( StudentName , UserName , Password ) values  ('" + Sn + "' , '" + Un + "' , '" + pd + "')  ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return 1;

        }
        public static int Staff(string Sn, int Ad)
        {
            
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  StudentAttendanceTable set AttendedDays='"+Ad+"' where StudentName='"+Sn+"' ", con);
            cmd.Parameters.AddWithValue("AttendedDays", Ad);
            cmd.ExecuteNonQuery();
            con.Close();
            return 1;

        }
        public static string Student(string Sn)
        {
            string Res = " ";
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select AttendedDays from StudentAttendanceTable where StudentName='" + Sn + "' ", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                Res = sdr.GetValue(0).ToString();
            }
            return Res;
           

        }
    }
}
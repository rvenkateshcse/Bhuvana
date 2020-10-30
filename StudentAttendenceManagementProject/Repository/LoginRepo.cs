using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Repository
{

    public abstract class LoginRepo
    {
        public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        public static SqlConnection con = new SqlConnection(constr);
        public  abstract int Login(string Un, string pd);
        public  abstract int Register(string Sn, string Un, string pd);
        public  abstract int Staff(string Sn, int Ad);
        public  abstract string Student(string Sn);
    }
    public class Home : LoginRepo
    {
        public  override int Login(string Un, string pd)
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

        public override int Register(string Sn, string Un, string pd)
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

        public override int Staff(string Sn, int Ad)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update  StudentAttendanceTable set AttendedDays='" + Ad + "' where StudentName='" + Sn + "' ", con);
            cmd.Parameters.AddWithValue("AttendedDays", Ad);
            cmd.ExecuteNonQuery();
            con.Close();
            return 1;
        }

        public override string Student(string Sn)
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
    }

}      
       
        
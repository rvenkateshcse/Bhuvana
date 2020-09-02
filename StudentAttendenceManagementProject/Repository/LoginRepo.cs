using System;
using System.Web;
using System.Data.SqlClient;

namespace Repository
{
    public static class LoginRepo
    {
        public static int Login(string Un, string pd, string role)
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
            int Res;
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into  StudentAttendanceTable( StudentName , UserName , Password ) values  ('" + Sn + "' , '" + Un + "' , '" + pd + "')  ", con);
            Res = cmd.ExecuteNonQuery() == 3 ? 1 : 0;
            con.Close();

            return Res;

        }
        public static int Staff(string Sn, int Ad)
        {
            int Res;
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  StudentAttendanceTable(AttendedDays) set AttendedDays='"+Ad+"' where StudentName='"+Sn+"' ", con);
            Res = cmd.ExecuteNonQuery() == 1?1:0;
            con.Close();

            return Res;

        }
        public static int Student(string Sn)
        {
            int Res;
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  StudentAttendanceTable(AttendedDays) set AttendedDays='" + Ad + "' where StudentName='" + Sn + "' ", con);
            Res = cmd.ExecuteNonQuery() == 1 ? 1 : 0;
            con.Close();

            return Res;

        }
    }
}

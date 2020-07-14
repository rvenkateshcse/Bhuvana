using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-HQNFTEO;initial catalog=master;integrated security=true;");
        

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student values('" +textBox1.Text+ "','" +textBox2.Text+ "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update student set stuname='" + textBox1.Text + "',rollno='" + textBox2.Text + "' where stuname='" + textBox1.Text + "'",con);
           cmd.CommandType = CommandType.Text;
            var datab = cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from student where stuname='" + textBox1.Text + "'",con);
           cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");
            con.Close();
        }
    }
}

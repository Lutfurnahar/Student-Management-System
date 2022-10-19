using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_management_system
{
    public partial class student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\information.mdf;Integrated Security=True;Connect Timeout=30");
        public student_info()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
           SqlCommand cmd = new SqlCommand("INSERT INTO Table3 VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox .Show("insert data sucessfully");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tabel1 SET Student_Name='" + textBox2.Text + "',Address='" + textBox3.Text + "',Class='" + textBox4.Text + "' WHERE Student_Id='" + textBox1.Text + "',con");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data successfully");
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Tabel1 WHERE Student_Id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete data sucessfully");
            con.Close();

        }
    }
}

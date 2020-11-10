using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapLon
{
    public partial class DSSinhVien : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=H:\Desktop\BaiTapLon\BaiTapLon\thongtin.mdf;Integrated Security=True;User Instance=True");

        public DSSinhVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGV m = new MainGV();
            m.Show();
        }

        private void DSSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongtinDataSet1.logints' table. You can move, or remove it, as needed.
            this.logintsTableAdapter.Fill(this.thongtinDataSet1.logints);
            dd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into logints values ('" + textBox2.Text + "', '" + textBox1.Text + "' ,'" + textBox5.Text + "' ,'" + textBox4.Text + "' ,'" + textBox3.Text + "' ,'" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox2.Text = "";
            textBox1.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            dd();
            MessageBox.Show("Success");
        }
        public void dd()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from logints";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from logints where masv = '"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();

            con.Close();
            dd();
            MessageBox.Show("Success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update logints set hoten = '" + textBox1 + "', lop = '" + textBox5 + "',ngaysinh = '" + textBox4 + "',password1 = '" + textBox3 + "',gioitinh = '" + textBox6 + "',pic = '" + textBox7 + "' where masv = '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            dd();
            MessageBox.Show("Success");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from logints where hoten='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }





    }
}





























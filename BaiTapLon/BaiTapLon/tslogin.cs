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
    public partial class tslogin : Form
    {
        public tslogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=|DataDirectory|\ToanBoThongTin.sdf");
            string query = "SELECT count(*) FROM logints WHERE masv='" + textBox1.Text + "' AND password1='" + textBox2.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                ThongTinSV t = new ThongTinSV();
                t.Show();
            }
            else
            {
                MessageBox.Show("sai");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

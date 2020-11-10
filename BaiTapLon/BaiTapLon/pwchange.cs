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
    public partial class pwchange : Form
    {
        public pwchange()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\thongtin.mdf;Integrated Security=True;User Instance=True");
            string query = "SELECT count(*) FROM tttk WHERE magv='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            SqlDataAdapter das = new SqlDataAdapter(query, con);
            DataTable dtt = new DataTable();
            das.Fill(dtt);

            errorProvider1.Clear();
            if (dtt.Rows[0][0].ToString() == "1")
            {
                if (textBox3.Text == textBox4.Text)
                {
                    SqlDataAdapter cc = new SqlDataAdapter("update tttk set password='" + textBox3.Text + "' where magv='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", con);
                    DataTable sd = new DataTable();
                    cc.Fill(sd);
                    MessageBox.Show("Password changed!", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(textBox3, "sai");
                    errorProvider1.SetError(textBox4, "sai");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "sai mk");
                errorProvider1.SetError(textBox2, "sai mk");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

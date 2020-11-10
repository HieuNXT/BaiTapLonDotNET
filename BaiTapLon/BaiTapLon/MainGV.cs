using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;


namespace BaiTapLon
{
    public partial class MainGV : Form
    {
        public MainGV()
        {
            InitializeComponent();
        }

        private void danhSáchSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSinhVien dssv = new DSSinhVien();
            dssv.Show();
        }

        private void soandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoanDe sd = new SoanDe();
            sd.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSDe ddd = new DSDe();
            ddd.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pwchange ps = new pwchange();
            ps.Show();
        }


    }
}





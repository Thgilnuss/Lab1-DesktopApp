using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Bai2_NguyenVanMinhHai
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtgia.Text = "20000";
            picDen.Hide();
            picXanh.Hide();
            picTrang.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txtgia.Text) * int.Parse(txtsoluong.Text);
            tien.Text = soTien.ToString();
            soTien = 0;
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void rdDen_CheckedChanged(object sender, EventArgs e)
        {
            txtgia.Text = "22000";
            picTrang.Hide();
            picXanh.Hide();
            picDen.Show();
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtgia.Text = "21000";
            picDen.Hide();
            picTrang.Hide();
            picXanh.Show();
        }
    }
}

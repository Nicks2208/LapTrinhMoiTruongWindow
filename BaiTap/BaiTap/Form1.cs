using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             lblHoTen.Text = txtHo.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void label4_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
 
        }


        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát?", "Tiêu đề thông báo",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = null;
        }
    }
}

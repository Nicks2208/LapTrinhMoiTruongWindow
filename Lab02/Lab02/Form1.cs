using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
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

        private void txt_Number1_TextChanged(object sender, EventArgs e)
        {

        }


        private void txt_Number1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Number2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sen6der, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                bool a = false;
                if (string.IsNullOrEmpty(txt_Number1.Text))
                {
                    err.SetError(txt_Number1, "Vui long nhap so thu 1");
                    a = true;
                }
                if (string.IsNullOrEmpty(txt_Number2.Text))
                {
                    err.SetError(txt_Number2, "Vui long nhap so thu 2");
                    a = true;
                }
                if (!a)
                {
                    float number1 = float.Parse(txt_Number1.Text);
                    float number2 = float.Parse(txt_Number2.Text);
                    float sum = number1 + number2;
                    MessageBox.Show($"> TONG LA : {sum}", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void btn_Tru_Click(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                bool a = false;
                if (string.IsNullOrEmpty(txt_Number1.Text))
                {
                    err.SetError(txt_Number1, "Vui long nhap so thu 1");
                    a = true;
                }
                if (string.IsNullOrEmpty(txt_Number2.Text))
                {
                    err.SetError(txt_Number2, "Vui long nhap so thu 2");
                    a = true;
                }
                if (!a)
                {
                    float number1 = float.Parse(txt_Number1.Text);
                    float number2 = float.Parse(txt_Number2.Text);
                    float minus = number1 - number2;
                    MessageBox.Show($"> HIEU LA : {minus}", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                bool a = false;
                if (string.IsNullOrEmpty(txt_Number1.Text))
                {
                    err.SetError(txt_Number1, "Vui long nhap so thu 1");
                    a = true;
                }
                if (string.IsNullOrEmpty(txt_Number2.Text))
                {
                    err.SetError(txt_Number2, "Vui long nhap so thu 2");
                    a = true;
                }
                if (!a)
                {
                    float number1 = float.Parse(txt_Number1.Text);
                    float number2 = float.Parse(txt_Number2.Text);
                    float nhan = number1 * number2;
                    MessageBox.Show($"> TICH LA : {nhan}", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                bool a = false;
                if (string.IsNullOrEmpty(txt_Number1.Text))
                {
                    err.SetError(txt_Number1, "Vui long nhap so thu 1");
                    a = true;
                }
                if (string.IsNullOrEmpty(txt_Number2.Text))
                {
                    err.SetError(txt_Number2, "Vui long nhap so thu 2");
                    a = true;
                }
                if (!a)
                {
                    float number1 = float.Parse(txt_Number1.Text);
                    float number2 = float.Parse(txt_Number2.Text);
                    float chia = number1 / number2;
                    MessageBox.Show($"> THUONG LA : {chia}", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}

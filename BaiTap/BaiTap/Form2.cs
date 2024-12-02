using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaiTap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtHoTen.Text.Trim();
            DateTime datetime = txtDateTime.Value;
            string ngaysinh = datetime.ToString("dd/MM/yyyy");
            string gioitinh = btnNam.Checked ? "Nam" : "Nu";
            string sothich = "";


            if (btn_TheThao.Checked)
                sothich += "Thể thao, ";

            if (btnDuLich.Checked)
                sothich += "Du lịch, ";

            if (btn_PhimAnh.Checked)
                sothich += "Phim ảnh";

            if (sothich.EndsWith(", "))
                sothich = sothich.Substring(0, sothich.Length - 2);

            DialogResult res = MessageBox.Show("Họ tên: " + name + ", Ngày Sinh: " + ngaysinh + ", Giới tính: " + gioitinh + ", Lựa chọn: " + sothich, "Thông tin người dùng", MessageBoxButtons.OK);
            
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGTAPVO
{
    public partial class FormHV : Form
    {
        //public FormHV()
        //{
        //    InitializeComponent();
        //}
        private Action<HocVien> AddHocVienMoi; // Biến lưu phương thức thêm học viên vào DataGridView

        public FormHV(Action<HocVien> AddHocVienMoi)
        {
            InitializeComponent();
            this.AddHocVienMoi = AddHocVienMoi; // Nhận phương thức từ Form1
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IDHV.Text) || string.IsNullOrWhiteSpace(txt_TenHV.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT.Text) || string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                (!rb_Nam.Checked && !rb_Nu.Checked)) // Kiểm tra nếu không chọn giới tính
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin học viên và chọn giới tính!");
                return;
            }

            if (!double.TryParse(txt_SDT.Text, out double luongCB))
            {
                MessageBox.Show("Lương cơ bản phải là số.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gioiTinh = rb_Nam.Checked ? "M" : "F";

            var newHocVien = new HocVien
            {
                ID_HocVien = txt_IDHV.Text,
                TenHocVien = txt_TenHV.Text,
                NgaySinh = dt_NgaySinh.Value,
                GioiTinh = gioiTinh,  // Lưu giới tính từ RadioButton
                DiaChi = txt_DiaChi.Text,
                SDT = txt_SDT.Text
            };

            // Thêm học viên vào cơ sở dữ liệu
            using (var context = new Model1())
            {
                context.HocViens.Add(newHocVien);
                context.SaveChanges();
            }

            // Truyền học viên vào phương thức đã nhận từ Form1
            AddHocVienMoi(newHocVien);

            // Hiển thị thông báo thành công
            MessageBox.Show("Học viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

 

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

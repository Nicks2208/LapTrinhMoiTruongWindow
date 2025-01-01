using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.models;

namespace GUI
{
    public partial class FormHV : Form
    {
        public HocVien HocVienMoi { get; private set; }

        public FormHV()
        {
            InitializeComponent();
        }
        public FormHV(HocVien hocVien)
        {
            InitializeComponent();
            RefeshData(hocVien);
            txt_IDHV.Enabled = false;
        }
       
        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Get data from the form fields
            string idHocVien = txt_IDHV.Text.Trim();
            string tenHocVien = txt_TenHV.Text.Trim();
            DateTime ngaySinh = dt_NgaySinh.Value;
            string sdt = txt_SDT.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();
            string gioiTinh = rb_Nam.Checked ? "M" : (rb_Nu.Checked ? "F" : "");
            string idLop = cb_Lop.SelectedValue as string;


            if (string.IsNullOrEmpty(idHocVien) || string.IsNullOrEmpty(tenHocVien) || string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(idLop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btn_Them.Text == "Đồng Ý")
            {
                using (var context = new Model1())
                {
                    var existingHocVien = context.HocViens.FirstOrDefault(hv => hv.ID_HocVien == idHocVien);
                    if (existingHocVien != null)
                    {
                        // Nếu mã HLV đã tồn tại, thông báo lỗi và không thêm
                        MessageBox.Show("Mã học viên viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    HocVien newHocVien = new HocVien
                    {
                        ID_HocVien = idHocVien,
                        TenHocVien = tenHocVien,
                        GioiTinh = gioiTinh,
                        NgaySinh = ngaySinh,
                        SDT = sdt,
                        DiaChi = diaChi,
                        ID_Lop = idLop // Gán ID lớp học cho học viên

                    };

                    context.HocViens.Add(newHocVien);
                    context.SaveChanges();
                    HocVienMoi = newHocVien;
                    MessageBox.Show("Thêm học viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                using (var context = new Model1())
                {
                    var existingHocVien = context.HocViens.FirstOrDefault(hv => hv.ID_HocVien == idHocVien);
                    existingHocVien.TenHocVien = tenHocVien;
                    existingHocVien.GioiTinh = gioiTinh;
                    existingHocVien.NgaySinh = ngaySinh;
                    existingHocVien.SDT = sdt;
                    existingHocVien.DiaChi = diaChi;
                    existingHocVien.ID_Lop = idLop; // Cập nhật ID lớp học cho học viên
                    context.SaveChanges();
                    HocVienMoi = existingHocVien;
                }

                MessageBox.Show("Cập nhật học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

      
            this.DialogResult = DialogResult.OK;
                this.Close();
        }

        public void RefeshData(HocVien hocVien)
        {
            txt_IDHV.Text = hocVien.ID_HocVien;
            txt_TenHV.Text = hocVien.TenHocVien;
            dt_NgaySinh.Value = hocVien.NgaySinh ?? DateTime.Now;
            rb_Nam.Checked = hocVien.GioiTinh == "M";
            rb_Nu.Checked = hocVien.GioiTinh == "F";
            txt_SDT.Text = hocVien.SDT;
            txt_DiaChi.Text = hocVien.DiaChi;
            cb_Lop.SelectedValue = hocVien.ID_Lop;


            btn_Them.Text = "Cập nhật";
        }

        private void FormHV_Load(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var lopHocs = context.LopHocs.ToList();
                cb_Lop.DisplayMember = "TenLop";  // Hiển thị tên lớp học
                cb_Lop.ValueMember = "ID_Lop";    // Giá trị được chọn là ID_Lop
                cb_Lop.DataSource = lopHocs;      // Gán dữ liệu vào ComboBox
            }
        }
    }
}

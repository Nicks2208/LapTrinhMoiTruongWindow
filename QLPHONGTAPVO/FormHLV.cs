using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGTAPVO
{
    public partial class FormHLV : Form
    {
        public HuanLuyenVien HLVMoi { get; private set; }
        public FormHLV()
        {
            InitializeComponent();
        }
        public FormHLV(HuanLuyenVien huanLuyenVien)
        {
            InitializeComponent();
            RefreshData(huanLuyenVien);
            txt_IDHLV.Enabled = false;
        }


        public void RefreshData(HuanLuyenVien huanLuyenVien)
        {
            // Set the controls to the passed data
            txt_IDHLV.Text = huanLuyenVien.ID_HLV;
            txt_TenHLV.Text = huanLuyenVien.TenHLV;
            rb_Nam.Checked = huanLuyenVien.GioiTinh == "M";
            rb_Nu.Checked = huanLuyenVien.GioiTinh == "F";
            txt_DiaChi.Text = huanLuyenVien.DiaChi;
            txt_SDT.Text = huanLuyenVien.SDT;
            combo_ChuyenMon.SelectedItem = huanLuyenVien.ChuyenMon;
            dt_NgaySinh.Value = huanLuyenVien.NgaySinh ?? DateTime.Now;  // Default to current date if null
            btn_DongY.Text = "Cập nhật";
        }


        private void btn_DongY_Click_1(object sender, EventArgs e)
        {
            string idHLV = txt_IDHLV.Text.Trim();
            string tenHLV = txt_TenHLV.Text.Trim();
            DateTime ngaySinh = dt_NgaySinh.Value;
            string sdt = txt_SDT.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();

            string gioiTinh = rb_Nam.Checked ? "M" : (rb_Nu.Checked ? "F" : "");


            if (string.IsNullOrEmpty(idHLV) || string.IsNullOrEmpty(tenHLV) || string.IsNullOrEmpty(gioiTinh) || combo_ChuyenMon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string chuyenMon = combo_ChuyenMon.SelectedItem.ToString(); // Lấy chuyên môn từ ComboBox
            if (btn_DongY.Text == "Đồng Ý")
            {
                using (var context = new Model1())
                {
                    var existingHLV = context.HuanLuyenViens.FirstOrDefault(hv => hv.ID_HLV == idHLV);
                    if (existingHLV != null)
                    {
                        // Nếu mã HLV đã tồn tại, thông báo lỗi và không thêm
                        MessageBox.Show("Mã huấn luyện viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    HuanLuyenVien newHLV = new HuanLuyenVien
                    {
                        ID_HLV = idHLV,
                        TenHLV = tenHLV,
                        GioiTinh = gioiTinh,
                        NgaySinh = ngaySinh,
                        SDT = sdt,
                        ChuyenMon = chuyenMon,
                        DiaChi = diaChi
                    };
                    context.HuanLuyenViens.Add(newHLV);
                    context.SaveChanges();
                    HLVMoi = newHLV;
                    MessageBox.Show("Thêm học viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                using (var context = new Model1())
                {
                    var existingHLV = context.HuanLuyenViens.FirstOrDefault(hv => hv.ID_HLV == idHLV);
                    existingHLV.TenHLV = tenHLV;
                    existingHLV.GioiTinh = gioiTinh;
                    existingHLV.NgaySinh = ngaySinh;
                    existingHLV.SDT = sdt;
                    existingHLV.ChuyenMon = chuyenMon;
                    existingHLV.DiaChi = diaChi;
                    context.SaveChanges();
                    HLVMoi = existingHLV;
                    MessageBox.Show("Cập nhật học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormHLV_Load(object sender, EventArgs e)
        {

        }
    }
}

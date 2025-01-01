using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.models;
namespace GUI
{
    public partial class FormLopHoc : Form
    {
        public LopHoc LopHocMoi { get; private set; }
        public FormLopHoc()
        {
            InitializeComponent();
        }
        public FormLopHoc(LopHoc lopHoc)
        {
            InitializeComponent();
            RefeshData(lopHoc);
            txt_IDLop.Enabled = false;
        }
        public void RefeshData(LopHoc lopHoc)
        {
            txt_IDLop.Text = lopHoc.ID_Lop;
            txt_TenLop.Text = lopHoc.TenLop;
            txt_ThoiGianHoc.Text = lopHoc.ThoiGianHoc;
            cb_TenHLV.SelectedValue = lopHoc.ID_HLV;


            btn_Them.Text = "Cập nhật";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Get data from the form fields for HocVien (Student)
            string idLop = txt_IDLop.Text.Trim();
            string tenLop = txt_TenLop.Text.Trim();
            string thoigianhoc = txt_ThoiGianHoc.Text.Trim();
            string idHLV = cb_TenHLV.SelectedValue as string;

            if (string.IsNullOrEmpty(idLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(thoigianhoc) || string.IsNullOrEmpty(idHLV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btn_Them.Text == "Đồng Ý")
            {
                using (var context = new Model1())
                {
                    var existingLopHoc = context.LopHocs.FirstOrDefault(hv => hv.ID_Lop == idLop);
                    if (existingLopHoc != null)
                    {
                        MessageBox.Show("Mã Lớp đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    LopHoc newLopHoc = new LopHoc
                    {
                        ID_Lop = idLop,
                        TenLop = tenLop,
                        ThoiGianHoc = thoigianhoc,
                        ID_HLV = idHLV
                    };
                    context.LopHocs.Add(newLopHoc);
                    context.SaveChanges();
                    LopHocMoi = newLopHoc;

                    MessageBox.Show("Thêm học lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                using (var context = new Model1())
                {
                    var existingLopHoc = context.LopHocs.FirstOrDefault(hv => hv.ID_Lop == idLop);
                    if (existingLopHoc != null)
                    {
                        existingLopHoc.TenLop = tenLop;
                        existingLopHoc.ThoiGianHoc = thoigianhoc;
                        existingLopHoc.ID_HLV= idHLV;
                        existingLopHoc.ID_Lop = idLop;
                        context.SaveChanges();

                        LopHocMoi = existingLopHoc;

                        MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("lớp học không tồn tại. Vui lòng kiểm tra lại mã lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var huanLuyenViens = context.HuanLuyenViens.ToList();
                cb_TenHLV.DisplayMember = "TenHLV";
                cb_TenHLV.ValueMember = "ID_HLV";
                cb_TenHLV.DataSource = huanLuyenViens;
            }
        }
    }
}

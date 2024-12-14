using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap03
{
    public partial class AddSinhVien : Form
    {
        private int stt = 0;
        List<string> maSoSinhVienList = new List<string>();
        public AddSinhVien()
        {
            InitializeComponent();
        }
        private void Refesh()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            cbKhoa.SelectedItem = "Công Nghệ Thông Tin";
            txtDiem.Text = "";
        }
        public string MaSoSinhVien { get; private set; }
        public string TenSinhVien { get; private set; }
        public string Khoa { get; private set; }
        public float DiemSinhVien { get; private set; }
        public List<string> listMSSV { get; set; }
        private void AddSinhVien_Load(object sender, EventArgs e)
        {
            InitializeComboBoxFaculity();
            cbKhoa.SelectedIndex = 0;
        }
        private bool IsMSSVDuplicate(string mssv)
        {
            for (int i = 0; i < listMSSV.Count; i++)
            {
                if (listMSSV[i] == mssv) return false;
            }
            return true;
        }

        private void InitializeComboBoxFaculity()
        {
            string[] facultys = { "Công nghệ thông tin", "Ngôn ngữ Anh", "Quản trị kinh doanh" };

            foreach (string item in facultys)
            {
                cbKhoa.Items.Add(item);
            }
            cbKhoa.SelectedText = "Công nghệ thông tin";
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát form thêm sinh viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đày đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!float.TryParse(txtDiem.Text, out float diem))
                {
                    MessageBox.Show("Điểm sinh viên phải là một số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.Parse(txtDiem.Text) < 0 || float.Parse(txtDiem.Text) > 10)
                {
                    MessageBox.Show("Điểm sinh viên phải trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (IsMSSVDuplicate(txtMaSV.Text))
                    {
                        MaSoSinhVien = txtMaSV.Text;
                        TenSinhVien = txtHoTen.Text;
                        Khoa = cbKhoa.SelectedItem.ToString();
                        DiemSinhVien = float.Parse(txtDiem.Text);
                        DialogResult = DialogResult.OK;
                        Refesh();
                    }
                    else
                    {
                        MessageBox.Show("Mã số sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }    
}

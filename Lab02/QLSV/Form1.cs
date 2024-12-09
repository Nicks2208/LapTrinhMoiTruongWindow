using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_ChuyenNghanh.Items.Add("CNTT");
            cb_ChuyenNghanh.Items.Add("QTKD");
            cb_ChuyenNghanh.Items.Add("NNA");

            cb_ChuyenNghanh.SelectedItem = "QTKD";

            rb_Nu.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btn_ThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                bool a = false;
                if (string.IsNullOrEmpty(txt_MSSV.Text))
                {
                    err.SetError(txt_MSSV, "Vui long nhap MSSV");
                    a = true;
                }
                if (string.IsNullOrEmpty(txt_HoTen.Text))
                {
                    err.SetError(txt_HoTen, "Vui long nhap ho ten");
                    a = true;
                }
                if (string.IsNullOrEmpty(txt_DTB.Text))
                {
                    err.SetError(txt_DTB, "Vui long nhap Diem trung binh");
                    a = true;
                }
                if (a)
                {
                    
                    MessageBox.Show($"Vui long nhap day du thong tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!Regex.IsMatch(txt_MSSV.Text, @"^\d{10}$"))
                    {
                        MessageBox.Show($"Ma so sinh vien khong hop le", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    double diemTrungBinh;
                    if (!double.TryParse(txt_DTB.Text, out diemTrungBinh) || diemTrungBinh < 0 || diemTrungBinh > 10)
                    {
                        MessageBox.Show($"Diem trung binh sinh vien khong hop le", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!Regex.IsMatch(txt_HoTen.Text, @"^[a-zA-Z\s]+$") || txt_HoTen.Text.Length < 3 || txt_HoTen.Text.Length > 100)
                    {
                        MessageBox.Show("Tên sinh viên không hợp lệ.");
                        return;
                    }
                    bool isExist = false;
                    foreach (DataGridViewRow row in dtg_qlsv.Rows)
                    {
                        if (row.Cells["MaSinhVien"].Value.ToString() == txt_MSSV.Text)
                        {
                            isExist = true;
                            break;
                        }
                    }

                    if (!isExist)
                    {
                        // Thêm sinh viên mới
                        dtg_qlsv.Rows.Add(txt_MSSV.Text, txt_HoTen.Text, diemTrungBinh);
                        MessageBox.Show("Thêm mới dữ liệu thành công!");
                    }
                    if (isExist)
                    {
                        foreach (DataGridViewRow row in dtg_qlsv.Rows)
                        {
                            if (row.Cells["MaSinhVien"].Value.ToString() == txt_MSSV.Text)
                            {
                                row.Cells["HoTen"].Value = txt_HoTen.Text;
                                row.Cells["DiemTrungBinh"].Value = diemTrungBinh;
                                MessageBox.Show("Cập nhật dữ liệu thành công!");
                                break;
                            }
                        }
                    }
                    MessageBox.Show($"test", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void dtg_qlsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView row = dtg_qlsv.Rows[e.RowIndex];
            if(e.RowIndex >= 0 &&  e.ColumnIndex >= 0)
            {
                txt_MSSV.Text = row.Cells[0].Value.ToString();
                txt_HoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Male")
                {
                    rb_Nam.Checked = true;
                }
                else
                {
                    rb_Nu.Checked = true;
                }
                txt_DTB.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}

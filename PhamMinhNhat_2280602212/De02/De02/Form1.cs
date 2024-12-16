using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace De02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_SanPham.Rows[e.RowIndex];

                txt_MaSP.Text = row.Cells["MaSP"].Value.ToString();
                txt_TenSP.Text = row.Cells["TenSP"].Value.ToString();
                dt_NgayNhap.Value = DateTime.Parse(row.Cells["NgayNhap"].Value.ToString());
                cb_LoaiSP.Text = row.Cells["LoaiSP"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load_SanPham();
            Load_SanPham();
            Load_LoaiSP();
            Refesh_Status();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txt_MaSP.Text) || string.IsNullOrWhiteSpace(txt_TenSP.Text) || cb_LoaiSP.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            //    return;
            //}
            //dtg_SanPham.Rows.Add(txt_MaSP.Text, txt_TenSP.Text, dt_NgayNhap.Value.ToString("dd/MM/yyyy"), cb_LoaiSP.Text);
            //Refesh_Status();
            if (string.IsNullOrWhiteSpace(txt_MaSP.Text) || string.IsNullOrWhiteSpace(txt_TenSP.Text) || cb_LoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            using (var context = new Model1())
            {
                var newProduct = new SanPham
                {
                    MaSP = txt_MaSP.Text,
                    TenSP = txt_TenSP.Text,
                    NgayNhap = dt_NgayNhap.Value,
                    MaLoai = cb_LoaiSP.SelectedItem.ToString()
                };

                context.SanPham.Add(newProduct);
                context.SaveChanges();

                Load_SanPham();
                Refesh_Status();
                MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtg_SanPham.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (var context = new Model1())
                    {
                        foreach (DataGridViewRow row in dtg_SanPham.SelectedRows)
                        {
                            var productId = row.Cells["col_MaSP"].Value.ToString();
                            var productToDelete = context.SanPham.FirstOrDefault(sp => sp.MaSP == productId);

                            if (productToDelete != null)
                            {
                                context.SanPham.Remove(productToDelete);
                            }
                        }
                        context.SaveChanges();

                        Load_SanPham();
                        Refesh_Status();
                        MessageBox.Show("Sản phẩm đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Load_SanPham()
        {
            using (var context = new Model1())
            {
                var sanPhams = context.SanPham
                    .Include("LoaiSP")
                    .ToList();

                dtg_SanPham.Rows.Clear();
                foreach (var sp in sanPhams)
                {
                    dtg_SanPham.Rows.Add(sp.MaSP, sp.TenSP, sp.NgayNhap?.ToString("yyyy-MM-dd"), sp.MaLoai);
                }
            }
        }
        private void Load_LoaiSP()
        {
            using (var context = new Model1())
            {
                var loaiSPs = context.LoaiSP.ToList();
                cb_LoaiSP.Items.Clear();
                foreach (var loai in loaiSPs)
                {
                    cb_LoaiSP.Items.Add(loai.MaLoai);
                }
                cb_LoaiSP.SelectedIndex = 0;
            }
        }
        private void Refesh_Status()
        {
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            dt_NgayNhap.Value = DateTime.Now;
            cb_LoaiSP.SelectedIndex = -1;



            //txt_MaSP.Focus();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    Model1 model1 = new Model1();
            //    string maSP = txt_MaSP.Text;
            //    SanPham sanPham = model1.SanPham.Find(maSP);


            //    if (sanPham != null)
            //    {
            //        sanPham.TenSP = txt_TenSP.Text;
            //        sanPham.NgayNhap = dt_NgayNhap.Value;
            //        sanPham.MaLoai = cb_LoaiSP.SelectedValue.ToString();

            //        model1.SaveChanges();
            //        BindGrid(model1.SanPham.ToList());
            //        MessageBox.Show("Cap nhap thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Khong tim thay san pham de cap nhap", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Loi khi cap nhap: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                if (dtg_SanPham.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtg_SanPham.SelectedRows[0];


                    if (string.IsNullOrWhiteSpace(txt_MaSP.Text) ||
                        string.IsNullOrWhiteSpace(txt_TenSP.Text) ||
                        cb_LoaiSP.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var context = new Model1())
                    {
                        var sanPham = context.SanPham.FirstOrDefault(sp => sp.MaSP == txt_MaSP.Text.Trim());

                        if (sanPham != null)
                        {
                            if (context.SanPham.Any(sp => sp.MaSP == txt_MaSP.Text.Trim() && sp.MaSP != sanPham.MaSP))
                            {
                                MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            sanPham.TenSP = txt_TenSP.Text;
                            sanPham.NgayNhap = dt_NgayNhap.Value;
                            sanPham.MaLoai = cb_LoaiSP.SelectedItem.ToString();

                            context.SaveChanges();

                            //selectedRow.Cells["col_MaSP"].Value = sanPham.MaSP;
                            selectedRow.Cells["col_TenSP"].Value = sanPham.TenSP;
                            selectedRow.Cells["col_NgayNhap"].Value = sanPham.NgayNhap.Value.ToString("dd/MM/yyyy");
                            selectedRow.Cells["col_LoaiSP"].Value = sanPham.MaLoai;

                            MessageBox.Show("Chỉnh sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Refesh_Status();
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_SanPham.SelectedRows.Count > 0)
                {
                    // Lấy dòng đã chọn từ DataGridView
                    DataGridViewRow selectedRow = dtg_SanPham.SelectedRows[0];

                    // Kiểm tra dữ liệu nhập vào từ form
                    if (string.IsNullOrWhiteSpace(txt_MaSP.Text) ||
                        string.IsNullOrWhiteSpace(txt_TenSP.Text) ||
                        cb_LoaiSP.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var context = new Model1()) // 'Model1' là context của bạn
                    {
                        var sanPham = context.SanPham.FirstOrDefault(sp => sp.MaSP == txt_MaSP.Text);
                        if (sanPham != null)
                        {
                            sanPham.TenSP = txt_TenSP.Text;
                            sanPham.NgayNhap = dt_NgayNhap.Value;
                            sanPham.MaLoai = cb_LoaiSP.SelectedItem.ToString();

                            context.SaveChanges();
                            MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    Refesh_Status();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchMaSP = txt_Search.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchMaSP))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var context = new Model1())
                {
                    var sanPham = context.SanPham.FirstOrDefault(sp => sp.MaSP == searchMaSP);

                    if (sanPham != null)
                    {
                        txt_MaSP.Text = sanPham.MaSP;
                        txt_TenSP.Text = sanPham.TenSP;
                        dt_NgayNhap.Value = sanPham.NgayNhap ?? DateTime.Now;
                        cb_LoaiSP.SelectedItem = sanPham.LoaiSP?.MaLoai;

                        // Cập nhật lại DataGridView với thông tin tìm được
                        BindGrid(new List<SanPham> { sanPham });

                        MessageBox.Show("Tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BindGrid(List<SanPham> listSanPham)
        {
            dtg_SanPham.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int index = dtg_SanPham.Rows.Add();
                dtg_SanPham.Rows[index].Cells[0].Value = item.MaSP; 
                dtg_SanPham.Rows[index].Cells[1].Value = item.TenSP;
                dtg_SanPham.Rows[index].Cells[2].Value = item.NgayNhap?.ToString("dd/MM/yyyy");
                dtg_SanPham.Rows[index].Cells[3].Value = item.LoaiSP?.MaLoai;
            }
        }
    }

}

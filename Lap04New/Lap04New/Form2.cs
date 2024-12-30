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

namespace Lap04New
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Load_Khoa()
        {
            using (var context = new Model1())
            {

                var az = context.Faculties
                    .ToList();

                dgvKhoa.Rows.Clear();
                foreach (var z in az)
                {
                    dgvKhoa.Rows.Add(z.FacultyID, z.FacultyName, z.TotalProfessor);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Load_Khoa();
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow selectRow = dgvKhoa.Rows[e.RowIndex];
                txtMakhoa.Text = selectRow.Cells[0].Value.ToString();
                txtTenkhoa.Text = selectRow.Cells[1].Value.ToString();
                txtTongGS.Text = selectRow.Cells[2].Value.ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ ô nhập liệu
            string maKhoa = txtMakhoa.Text.Trim();
            string tenKhoa = txtTenkhoa.Text.Trim();
            string tongSoGS = txtTongGS.Text.Trim();

            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa) || string.IsNullOrEmpty(tongSoGS))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng mã khoa (không chứa ký tự đặc biệt)
            if (!System.Text.RegularExpressions.Regex.IsMatch(maKhoa, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã khoa không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tổng số GS là số hợp lệ từ 0 đến 15
            if (!int.TryParse(tongSoGS, out int soGS) || soGS < 0 || soGS > 15)
            {
                MessageBox.Show("Tổng số giáo sư không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tên khoa (độ dài và không chứa ký tự đặc biệt)
            if (!System.Text.RegularExpressions.Regex.IsMatch(tenKhoa, @"^[a-zA-Z\s]{3,100}$"))
            {
                MessageBox.Show("Tên khoa không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã khoa đã tồn tại hay chưa trong DataGridView
            bool daTonTai = false;

            foreach (DataGridViewRow row in dgvKhoa.Rows)
            {
                if (row.Cells["MaKhoa"].Value != null && row.Cells["MaKhoa"].Value.ToString() == maKhoa)
                {
                    // Cập nhật dữ liệu nếu mã khoa đã tồn tại
                    row.Cells["TenKhoa"].Value = tenKhoa;
                    row.Cells["TongSoGS"].Value = soGS;
                    daTonTai = true;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            // Nếu mã khoa chưa tồn tại thì thêm mới vào DataGridView
            if (!daTonTai)
            {
                dgvKhoa.Rows.Add(maKhoa, tenKhoa, soGS);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Trở về trạng thái mặc định
            txtMakhoa.Clear();
            txtTenkhoa.Clear();
            txtTongGS.Clear();
            txtMakhoa.Focus();

        }
        private void BindGrid(List<Faculty> listFalcultys)
        {
            dgvKhoa.Rows.Clear();
            foreach (var item in listFalcultys)
            {
                int index = dgvKhoa.Rows.Add();
                dgvKhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dgvKhoa.Rows[index].Cells[1].Value = item.FacultyName;
                dgvKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMakhoa.Text.Trim(); // Lấy mã khoa cần xóa

            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập mã khoa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool khoaTonTai = false;

            // Duyệt qua các dòng trong DataGridView để kiểm tra mã khoa
            foreach (DataGridViewRow row in dgvKhoa.Rows)
            {
                if (row.Cells["MaKhoa"].Value != null && row.Cells["MaKhoa"].Value.ToString() == maKhoa)
                {
                    khoaTonTai = true;

                    // Hiển thị hộp thoại xác nhận
                    var result = MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Xóa dòng khỏi DataGridView
                        dgvKhoa.Rows.Remove(row);
                        MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                }
            }

            // Nếu mã khoa không tồn tại, hiển thị thông báo lỗi
            if (!khoaTonTai)
            {
                MessageBox.Show("Mã khoa không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cập nhật lại tổng số giáo sư sau khi xóa
            CapNhatTongSoGS();

            // Sắp xếp lại các khoa theo số lượng giáo sư sau khi xóa
            SortDataGridView();
        }
        private void CapNhatTongSoGS()
        {
            int tongSoGS = 0;

            // Duyệt qua tất cả các dòng trong DataGridView để tính tổng số Giáo Sư
            foreach (DataGridViewRow row in dgvKhoa.Rows)
            {
                if (row.Cells["TongSoGS"].Value != null)
                {
                    int soGS;
                    if (int.TryParse(row.Cells["TongSoGS"].Value.ToString(), out soGS))
                    {
                        tongSoGS += soGS;
                    }
                }
            }

            // Cập nhật kết quả vào TextBox tổng số GS (đặt là txtTongSoGSHienThi)
            txtTongGS.Text = tongSoGS.ToString();
        }
        // Phương thức sắp xếp lại DataGridView theo số lượng giáo sư
        private void SortDataGridView()
        {
            var sortedRows = dgvKhoa.Rows.Cast<DataGridViewRow>()
                .OrderBy(row => Convert.ToInt32(row.Cells["TongSoGS"].Value)) // Sắp xếp theo số lượng giáo sư tăng dần
                .ToList();

            // Xóa toàn bộ dữ liệu hiện tại trong DataGridView
            dgvKhoa.Rows.Clear();

            // Thêm lại các dòng đã được sắp xếp vào DataGridView
            foreach (var row in sortedRows)
            {
                dgvKhoa.Rows.Add(row);
            }
        }
    }
}

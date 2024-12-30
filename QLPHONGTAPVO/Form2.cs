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

namespace QLPHONGTAPVO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        public void Load_HLV()
        {
            using (var context = new Model1())
            {

                var az = context.HuanLuyenViens
                    .ToList();

                dtg_HLV.Rows.Clear();
                foreach (var z in az)
                {
                    dtg_HLV.Rows.Add(z.ID_HLV, z.TenHLV, z.GioiTinh, z.NgaySinh?.ToString("yyyy-MM-dd"), z.DiaChi, z.SDT, z.ChuyenMon);
                }
            }
        }
        public void TimHLV(string selectedHocVienID)
        {
            using (var context = new Model1())
            {
                // Lấy thông tin HLV liên quan đến học viên
                var hocVien = context.HocViens
                    .Include("TheHocViens.LopHoc.HuanLuyenVien") // Lấy thông tin về HLV qua mối quan hệ
                    .FirstOrDefault(hv => hv.ID_HocVien == selectedHocVienID);

                if (hocVien != null)
                {
                    // Lấy thông tin HLV từ mối quan hệ
                    var huanLuyenVien = hocVien.TheHocViens
                        .Select(thv => thv.LopHoc.HuanLuyenVien)
                        .FirstOrDefault();

                    if (huanLuyenVien != null)
                    {
                        // Dọn dẹp DataGridView trước khi thêm dữ liệu
                        dtg_HLV.Rows.Clear();

                        // Thêm thông tin HLV vào DataGridView
                        dtg_HLV.Rows.Add(
                            huanLuyenVien.ID_HLV,
                            huanLuyenVien.TenHLV,
                            huanLuyenVien.GioiTinh,
                            huanLuyenVien.NgaySinh?.ToString("yyyy-MM-dd"),
                            huanLuyenVien.DiaChi,
                            huanLuyenVien.SDT,
                            huanLuyenVien.ChuyenMon
                        );
                    }
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormHLV formHLV = new FormHLV();
            formHLV.ShowDialog(); // Hiển thị form nhập liệu dưới dạng cửa sổ modal (đợi người dùng nhập liệu)

            // Kiểm tra nếu form được đóng và người dùng nhấn "OK" (tức là huấn luyện viên đã được thêm thành công)
            if (formHLV.DialogResult == DialogResult.OK)
            {
                HuanLuyenVien newHLV = formHLV.HLVMoi;
                dtg_HLV.Rows.Add(newHLV.ID_HLV, newHLV.TenHLV, newHLV.GioiTinh,
                                 newHLV.NgaySinh.Value.ToString("yyyy-MM-dd"), newHLV.SDT,
                                 newHLV.ChuyenMon, newHLV.DiaChi);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtg_HLV.SelectedRows.Count > 0)
            {
                int index = dtg_HLV.SelectedRows[0].Index;
                var selectedHLVID = dtg_HLV.Rows[index].Cells["col_IDHLV"].Value.ToString();

                // Create HuanLuyenVien object with selected row data
                var hlv = new HuanLuyenVien
                {
                    ID_HLV = selectedHLVID,
                    TenHLV = dtg_HLV.Rows[index].Cells["col_TenHLV"].Value.ToString(),
                    GioiTinh = dtg_HLV.Rows[index].Cells["col_GioiTinh"].Value.ToString(),
                    NgaySinh = Convert.ToDateTime(dtg_HLV.Rows[index].Cells["col_NgaySinh"].Value),
                    SDT = dtg_HLV.Rows[index].Cells["col_SDT"].Value.ToString(),
                    ChuyenMon = dtg_HLV.Rows[index].Cells["col_ChuyenMon"].Value.ToString(),
                    DiaChi = dtg_HLV.Rows[index].Cells["col_DiaChi"].Value.ToString()
                };

                // Open FormHLV to edit the selected trainer
                FormHLV formHLV = new FormHLV(hlv);
                formHLV.RefreshData(hlv);

                if (formHLV.ShowDialog() == DialogResult.OK)
                {
                    // Get the updated trainer data from FormHLV
                    var updatedHLV = formHLV.HLVMoi;

                    // Update the DataGridView with the edited data
                    dtg_HLV.Rows[index].Cells["col_TenHLV"].Value = updatedHLV.TenHLV;
                    dtg_HLV.Rows[index].Cells["col_GioiTinh"].Value = updatedHLV.GioiTinh;
                    dtg_HLV.Rows[index].Cells["col_NgaySinh"].Value = updatedHLV.NgaySinh.Value.ToString("yyyy-MM-dd");
                    dtg_HLV.Rows[index].Cells["col_SDT"].Value = updatedHLV.SDT;
                    dtg_HLV.Rows[index].Cells["col_ChuyenMon"].Value = updatedHLV.ChuyenMon;
                    dtg_HLV.Rows[index].Cells["col_DiaChi"].Value = updatedHLV.DiaChi;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtg_HLV.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn trong DataGridView
                var selectedRow = dtg_HLV.SelectedRows[0];

                // Kiểm tra nếu cột "ID_HocVien" tồn tại và lấy giá trị của nó
                if (selectedRow.Cells["col_IDHLV"] != null)
                {
                    string idHLV = selectedRow.Cells["col_IDHLV"].Value.ToString();

                    // Hỏi người dùng xác nhận trước khi xóa
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Xóa học viên khỏi cơ sở dữ liệu
                        using (var context = new Model1())
                        {
                            var hlvToDelete = context.HuanLuyenViens.FirstOrDefault(hv => hv.ID_HLV == idHLV);
                            if (hlvToDelete != null)
                            {
                                context.HuanLuyenViens.Remove(hlvToDelete);
                                context.SaveChanges();
                            }
                        }

                        // Xóa dòng được chọn khỏi DataGridView
                        dtg_HLV.Rows.Remove(selectedRow);

                        // Thông báo cho người dùng
                        MessageBox.Show("Huan Luyen Vien đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cột ID_HLV!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

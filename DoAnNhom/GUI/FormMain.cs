using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.models;

namespace GUI
{
    public partial class FormMain : Form
    {
        private readonly HV_GET hvget = new HV_GET();
        private readonly Class_GET classget = new Class_GET();
        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_HV();
            Load_HLV();
            Load_LopHoc();
        }


        /* -------------------------------- HỌC VIÊN  -------------------------------- */
        public void Load_HV()
        {
            //using (var context = new Model1())
            //{

            //    var az = context.HocViens
            //        .ToList();

            //    dtg_QLHOCVO.Rows.Clear();

            //    foreach (var z in az)
            //    {
            //        string tenLop = z.LopHoc != null ? z.LopHoc.TenLop : "Chưa có lớp";
            //        dtg_QLHOCVO.Rows.Add(z.ID_HocVien, z.TenHocVien, z.GioiTinh, z.NgaySinh?.ToString("yyyy-MM-dd"), z.SDT, z.DiaChi, tenLop);
            //    }

            //}
            try
            {     // Fetch data from BLL
                var listHocVien = hvget.GetAll();

                // Bind data to GridView
                GetHVFromDTG(listHocVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetHVFromDTG(List<HocVien> listHocvien)
        {
            dtg_QLHOCVO.Rows.Clear();
            foreach (var item in listHocvien)
            {
                int index = dtg_QLHOCVO.Rows.Add();
                dtg_QLHOCVO.Rows[index].Cells[0].Value = item.ID_HocVien;
                dtg_QLHOCVO.Rows[index].Cells[1].Value = item.TenHocVien;
                dtg_QLHOCVO.Rows[index].Cells[2].Value = item.GioiTinh;
                dtg_QLHOCVO.Rows[index].Cells[3].Value = item.NgaySinh;
                dtg_QLHOCVO.Rows[index].Cells[4].Value = item.SDT;
                dtg_QLHOCVO.Rows[index].Cells[5].Value = item.DiaChi;
                //if (item.ID_Lop != null)
                //    dtg_QLHOCVO.Rows[index].Cells[6].Value = item.LopHoc.TenLop + "";
                if (item.ID_Lop != null)
                    dtg_QLHOCVO.Rows[index].Cells[6].Value = item.LopHoc?.TenLop ?? "Chưa có lớp";
                //LoadAvatar(item.StudentID);
            }
        }

        private void dtg_QLHOCVO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the click is on a valid row (not the header)
            if (dtg_QLHOCVO.SelectedRows.Count >= -1)  // Ensure the row index is valid and not the header
            {
                // Get the clicked row's index
                int index = e.RowIndex;

                // Lấy giá trị từ các cột trong dòng đã chọn
                string idHocVien = dtg_QLHOCVO.Rows[index].Cells["col_IDHV"].Value.ToString();
                string tenHocVien = dtg_QLHOCVO.Rows[index].Cells["col_TenHV"].Value.ToString();
                string gioiTinh = dtg_QLHOCVO.Rows[index].Cells["col_GioiTinh"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(dtg_QLHOCVO.Rows[index].Cells["col_NgaySinh"].Value);
                string sdt = dtg_QLHOCVO.Rows[index].Cells["col_SDT"].Value.ToString();
                string diaChi = dtg_QLHOCVO.Rows[index].Cells["col_DiaChi"].Value.ToString();
                string tenLop = dtg_QLHOCVO.Rows[index].Cells["col_Lop"].Value.ToString();


                // Set values to the textboxes
                txt_IDHV.Text = idHocVien;
                txt_TenHV.Text = tenHocVien;
                txt_NgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                txt_DiaChi.Text = diaChi;
                txt_SDT.Text = sdt;
                txt_Lop.Text = tenLop;

                // Set gender in combo box (if using combo box)
                if (gioiTinh == "M")
                {
                    rb_Nam.Checked = true;
                }
                else if (gioiTinh == "F")
                {
                    rb_Nu.Checked = true; // Set the RadioButton for female
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
        public void BindGrid(List<HocVien> listHocVien)
        {

            dtg_QLHOCVO.Rows.Clear();

            foreach (var z in listHocVien)
            {
                string tenLop = z.LopHoc != null ? z.LopHoc.TenLop : "Chưa có lớp";
                dtg_QLHOCVO.Rows.Add(z.ID_HocVien, z.TenHocVien, z.GioiTinh, z.NgaySinh?.ToString("yyyy-MM-dd"), z.SDT, z.DiaChi, tenLop);
            }
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length == 0)
                Load_HV();
            string searchTerm = txt_Search.Text.Trim().ToLower();
            using (var context = new Model1())
            {
                var hocViens = context.HocViens
                    .Where(hv => hv.ID_HocVien.Contains(searchTerm) ||
                                hv.TenHocVien.ToLower().Contains(searchTerm) || hv.DiaChi.ToLower().Contains(searchTerm) || hv.SDT.ToLower().Contains(searchTerm)
                    )
                    .ToList();

                if (hocViens.Any())
                {
                    BindGrid(hocViens);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_ThemHV_Click(object sender, EventArgs e)
        {
            //FormHV formHV = new FormHV(AddHocVienMoi);
            //formHV.ShowDialog();
            FormHV formHV = new FormHV();
            formHV.ShowDialog();

            if (formHV.DialogResult == DialogResult.OK)
            {
                // Update the DataGridView in Form1
                HocVien newHocVien = formHV.HocVienMoi;
                string tenLop = string.Empty;
                using (var context = new Model1()) // Giả sử Model1 là context của bạn
                {
                    var lopHoc = context.LopHocs.FirstOrDefault(lh => lh.ID_Lop == newHocVien.ID_Lop);
                    if (lopHoc != null)
                    {
                        tenLop = lopHoc.TenLop; // Lấy tên lớp
                    }
                }
                dtg_QLHOCVO.Rows.Add(newHocVien.ID_HocVien, newHocVien.TenHocVien, newHocVien.GioiTinh, newHocVien.NgaySinh?.ToString("yyyy-MM-dd"), newHocVien.SDT, newHocVien.DiaChi, tenLop);
            }

        }

        private void btn_SuaHV_Click(object sender, EventArgs e)
        {
            if (dtg_QLHOCVO.SelectedRows.Count > 0)
            {
                int index = dtg_QLHOCVO.SelectedRows[0].Index;
                var selectedHocVienID = dtg_QLHOCVO.Rows[index].Cells["col_IDHV"].Value.ToString();

                // Tạo đối tượng HocVien từ dữ liệu trong DataGridView
                var hocVien = new HocVien
                {
                    ID_HocVien = selectedHocVienID,
                    TenHocVien = dtg_QLHOCVO.Rows[index].Cells["col_TenHV"].Value.ToString(),
                    GioiTinh = dtg_QLHOCVO.Rows[index].Cells["col_GioiTinh"].Value.ToString(),
                    NgaySinh = Convert.ToDateTime(dtg_QLHOCVO.Rows[index].Cells["col_NgaySinh"].Value),
                    SDT = dtg_QLHOCVO.Rows[index].Cells["col_SDT"].Value.ToString(),
                    DiaChi = dtg_QLHOCVO.Rows[index].Cells["col_DiaChi"].Value.ToString(),
                    ID_Lop = dtg_QLHOCVO.Rows[index].Cells["col_Lop"].Value.ToString()
                };

                // Mở FormHV và truyền dữ liệu học viên vào
                FormHV formHV = new FormHV(hocVien);
                formHV.RefeshData(hocVien);

                // Kiểm tra xem FormHV có được đóng với DialogResult.OK không
                if (formHV.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi sửa xong, cập nhật lại DataGridView với thông tin học viên đã sửa
                    var updatedHocVien = formHV.HocVienMoi;

                    // Cập nhật lại dữ liệu trong DataGridView
                    dtg_QLHOCVO.Rows[index].Cells["col_TenHV"].Value = updatedHocVien.TenHocVien;
                    dtg_QLHOCVO.Rows[index].Cells["col_GioiTinh"].Value = updatedHocVien.GioiTinh;
                    dtg_QLHOCVO.Rows[index].Cells["col_NgaySinh"].Value = updatedHocVien.NgaySinh.Value.ToString("yyyy-MM-dd");
                    dtg_QLHOCVO.Rows[index].Cells["col_SDT"].Value = updatedHocVien.SDT;
                    dtg_QLHOCVO.Rows[index].Cells["col_DiaChi"].Value = updatedHocVien.DiaChi;
                    using (var context = new Model1())
                    {
                        var lopHoc = context.LopHocs.FirstOrDefault(lh => lh.ID_Lop == updatedHocVien.ID_Lop);
                        if (lopHoc != null)
                        {
                            // Cập nhật tên lớp vào DataGridView
                            dtg_QLHOCVO.Rows[index].Cells["col_Lop"].Value = lopHoc.TenLop; // Cập nhật tên lớp
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaHV_Click(object sender, EventArgs e)
        {
            if (dtg_QLHOCVO.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn trong DataGridView
                var selectedRow = dtg_QLHOCVO.SelectedRows[0];

                // Kiểm tra nếu cột "ID_HocVien" tồn tại và lấy giá trị của nó
                if (selectedRow.Cells["col_IDHV"] != null)
                {
                    string idHocVien = selectedRow.Cells["col_IDHV"].Value.ToString();

                    // Hỏi người dùng xác nhận trước khi xóa
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Xóa học viên khỏi cơ sở dữ liệu
                        using (var context = new Model1())
                        {
                            var hocVienToDelete = context.HocViens.FirstOrDefault(hv => hv.ID_HocVien == idHocVien);
                            if (hocVienToDelete != null)
                            {
                                context.HocViens.Remove(hocVienToDelete);
                                context.SaveChanges();
                            }
                        }

                        // Xóa dòng được chọn khỏi DataGridView
                        dtg_QLHOCVO.Rows.Remove(selectedRow);

                        // Thông báo cho người dùng
                        MessageBox.Show("Học viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cột ID_HocVien!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ThoatHV_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabCtrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabCtrl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabCtrl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.DarkCyan, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                //e.DrawBackground();
                //_textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.LightBlue, e.Bounds);
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)13.0, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Near;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

            // Draw image if available
            int indent = 3;
            Rectangle rect = new Rectangle(e.Bounds.X, e.Bounds.Y + indent, e.Bounds.Width, e.Bounds.Height - indent);
            if (tabCtrl.TabPages[e.Index].ImageIndex >= 0)
            {
                Image img = tabCtrl.ImageList.Images[tabCtrl.TabPages[e.Index].ImageIndex];
                float _x = (rect.X + rect.Width) - img.Width - 2 * indent;
                float _y = ((rect.Height - img.Height) / 2.0f) + rect.Y;
                e.Graphics.DrawImage(img, _x, _y);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void pb_RefeshHV_Click(object sender, EventArgs e)
        {
            Load_HV();
            MessageBox.Show("Đã load lại dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /* -------------------------------- HUẤN LUYỆN VIÊN -------------------------------- */
        public void Load_HLV()
        {
            using (var context = new Model1())
            {

                var az = context.HuanLuyenViens
                    .ToList();

                dtg_HLV.Rows.Clear();
                foreach (var z in az)
                {
                    dtg_HLV.Rows.Add(z.ID_HLV, z.TenHLV, z.GioiTinh, z.NgaySinh?.ToString("yyyy-MM-dd"), z.SDT, z.ChuyenMon, z.DiaChi);
                }
            }
        }

        private void btn_ThemHLV_Click(object sender, EventArgs e)
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

        private void btn_SuaHLV_Click(object sender, EventArgs e)
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
                    GioiTinh = dtg_HLV.Rows[index].Cells["col_GioiTinhHLV"].Value.ToString(),
                    NgaySinh = Convert.ToDateTime(dtg_HLV.Rows[index].Cells["col_NgaySinhHLV"].Value),
                    SDT = dtg_HLV.Rows[index].Cells["col_SDTHLV"].Value.ToString(),
                    ChuyenMon = dtg_HLV.Rows[index].Cells["col_ChuyenMon"].Value.ToString(),
                    DiaChi = dtg_HLV.Rows[index].Cells["col_DiaChiHLV"].Value.ToString()
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
                    dtg_HLV.Rows[index].Cells["col_GioiTinhHLV"].Value = updatedHLV.GioiTinh;
                    dtg_HLV.Rows[index].Cells["col_NgaySinhHLV"].Value = updatedHLV.NgaySinh.Value.ToString("yyyy-MM-dd");
                    dtg_HLV.Rows[index].Cells["col_SDTHLV"].Value = updatedHLV.SDT;
                    dtg_HLV.Rows[index].Cells["col_ChuyenMon"].Value = updatedHLV.ChuyenMon;
                    dtg_HLV.Rows[index].Cells["col_DiaChiHLV"].Value = updatedHLV.DiaChi;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaHLV_Click(object sender, EventArgs e)
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
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa huấn luyện viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("Vui lòng chọn một huấn luyện viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        /* -------------------------------- LỚP HỌC -------------------------------- */

        public void Load_LopHoc()
        {
            using (var context = new Model1())
            {

                var az = context.LopHocs
                    .ToList();

                dtgLopHoc.Rows.Clear();
                foreach (var z in az)
                {
                    string tenHLV = z.HuanLuyenVien != null ? z.HuanLuyenVien.TenHLV : "Chưa có HLV";
                    dtgLopHoc.Rows.Add(z.ID_Lop, z.TenLop, tenHLV, z.ThoiGianHoc);
                }
            }
            int solophoc = dtgLopHoc.Rows.Count;
            if (dtgLopHoc.AllowUserToAddRows)
            {
                solophoc--; // Giảm đi 1 nếu cho phép thêm dòng trống
            }
            txt_tongsolophoc.Text = solophoc.ToString();



        }
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            FormLopHoc formLopHoc = new FormLopHoc();
            formLopHoc.ShowDialog();

            if (formLopHoc.DialogResult == DialogResult.OK)
            {
                LopHoc newLopHoc = formLopHoc.LopHocMoi;
                dtgLopHoc.Rows.Add(newLopHoc.ID_Lop, newLopHoc.TenLop, newLopHoc.ID_HLV, newLopHoc.ThoiGianHoc);
            }
        }

        private void btn_SuaLop_Click(object sender, EventArgs e)
        {
            if (dtgLopHoc.SelectedRows.Count > 0)
            {
                int index = dtgLopHoc.SelectedRows[0].Index;
                var selectedLopHocID = dtgLopHoc.Rows[index].Cells["col_IDLop"].Value.ToString();

                var lopHoc = new LopHoc
                {
                    ID_Lop = selectedLopHocID,
                    TenLop = dtgLopHoc.Rows[index].Cells["col_TenLop"].Value.ToString(),
                    ThoiGianHoc = dtgLopHoc.Rows[index].Cells["col_ThoiGianHoc"].Value.ToString()
                };

                FormLopHoc formLopHoc = new FormLopHoc(lopHoc);
                formLopHoc.RefeshData(lopHoc);
                if (formLopHoc.ShowDialog() == DialogResult.OK)
                {
                    var updatedLopHoc = formLopHoc.LopHocMoi;


                    dtgLopHoc.Rows[index].Cells["col_TenLop"].Value = updatedLopHoc.TenLop;
                    dtgLopHoc.Rows[index].Cells["col_ThoiGianHoc"].Value = updatedLopHoc.ThoiGianHoc;
                    using (var context = new Model1())
                    {
                        var huanluyenvien = context.HuanLuyenViens.FirstOrDefault(lh => lh.ID_HLV == updatedLopHoc.ID_HLV);
                        if (huanluyenvien != null)
                        {
                            // Update the class name in DataGridView
                            dtgLopHoc.Rows[index].Cells["col_IDHLV_Lop"].Value = huanluyenvien.TenHLV;
                        }
                        else
                        {
                            // In case the class is not found, you might want to handle it
                            dtgLopHoc.Rows[index].Cells["col_IDHLV_Lop"].Value = "Chưa có HLV";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaLop_Click(object sender, EventArgs e)
        {
            if (dtgLopHoc.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn trong DataGridView
                var selectedRow = dtgLopHoc.SelectedRows[0];

                // Kiểm tra nếu cột "ID_HocVien" tồn tại và lấy giá trị của nó
                if (selectedRow.Cells["col_IDLop"] != null)
                {
                    string idLopHoc = selectedRow.Cells["col_IDLop"].Value.ToString();

                    // Hỏi người dùng xác nhận trước khi xóa
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Xóa học viên khỏi cơ sở dữ liệu
                        using (var context = new Model1())
                        {
                            var lopHocToDelete = context.LopHocs.FirstOrDefault(hv => hv.ID_Lop == idLopHoc);
                            if (lopHocToDelete != null)
                            {
                                context.LopHocs.Remove(lopHocToDelete);
                                context.SaveChanges();
                            }
                        }

                        // Xóa dòng được chọn khỏi DataGridView
                        dtgLopHoc.Rows.Remove(selectedRow);

                        // Thông báo cho người dùng
                        MessageBox.Show("Lớp học đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cột ID_Lop!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}

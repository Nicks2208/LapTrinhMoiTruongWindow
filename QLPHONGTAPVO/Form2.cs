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
        //public Form2z(string hocVienIDz)
        //{
        //    InitializeComponent();
        //    hocVienID = hocVienIDz;
        //}
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
            //using (var context = new Model1())
            //{
            //    // Lấy thông tin học viên cùng với các thông tin liên quan
            //    var hocVien = context.HocViens
            //        .Include(hv => hv.TheHocViens)  // Bao gồm thông tin về Thẻ Học Viên
            //        .Include(hv => hv.TheHocViens.Select(thv => thv.LopHoc))  // Bao gồm thông tin về Lớp Học của Thẻ Học Viên
            //        .Include(hv => hv.TheHocViens.Select(thv => thv.LopHoc.HuanLuyenVien))  // Bao gồm thông tin về HLV của Lớp Học
            //        .FirstOrDefault(hv => hv.ID_HocVien == selectedHocVienID);

            //    if (hocVien != null)
            //    {
            //        // Lấy thông tin thẻ học viên (có thể là danh sách hoặc một thẻ học viên duy nhất)
            //        var theHocVien = hocVien.TheHocViens.FirstOrDefault();

            //        if (theHocVien != null)
            //        {
            //            // Hiển thị thông tin thẻ học viên trong DataGridView hoặc các control khác
            //            dtg_HLV.Rows.Clear();  // Dọn dẹp trước khi thêm dữ liệu mới

            //            // Thêm dữ liệu vào DataGridView với thông tin thẻ học viên và thông tin huấn luyện viên
            //            dtg_HLV.Rows.Add(
            //                theHocVien.ID_TheHV,  // ID Thẻ Học Viên
            //                theHocVien.NgayDangKy?.ToString("yyyy-MM-dd"),  // Ngày đăng ký (nếu có)
            //                theHocVien.LopHoc.TenLop,  // Tên lớp học của học viên
            //                theHocVien.LopHoc.HuanLuyenVien.TenHLV,  // Tên huấn luyện viên của lớp học
            //                theHocVien.LopHoc.HuanLuyenVien.SDT,  // Số điện thoại của huấn luyện viên
            //                theHocVien.LopHoc.HuanLuyenVien.DiaChi  // Địa chỉ của huấn luyện viên
            //            );
            //        }
            //        else
            //        {
            //            MessageBox.Show("Không tìm thấy thẻ học viên cho học viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy học viên với ID này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }
    }
}

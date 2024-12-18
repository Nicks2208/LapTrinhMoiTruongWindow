using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGTAPVO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_QLHOCVO();
        }
        private void Load_QLHOCVO()
        {
            using (var context = new Model1())
            {

                var az = context.HocViens
                    .ToList();

                //dtg_QLHOCVO.Rows.Clear();
                foreach (var z in az)
                {
                    dtg_QLHOCVO.Rows.Add(z.ID_HocVien, z.TenHocVien, z.GioiTinh, z.NgaySinh?.ToString("yyyy-MM-dd"), z.SDT, z.DiaChi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Load_HLV();
            form2.Show();
        }

        private void btn_TimHLV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_QLHOCVO.SelectedRows.Count > 0)
                {
                    //DataGridViewRow selectedRow = dtg_QLHOCVO.SelectedRows[0];
                    //var selectedHocVienID = dtg_QLHOCVO.Rows[e.RowIndex].Cells["ID_HocVien"].Value.ToString();
                    //var productId = row.Cells["col_MaSP"].Value.ToString();
                    Form2 form2 = new Form2();
                    form2.TimHLV("HV_01");
                    form2.Show();  // Mở Form2
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_QLHOCVO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng không click vào tiêu đề cột
            if (e.RowIndex >= 0)
            {
                
                var selectedHocVienID = dtg_QLHOCVO.Rows[e.RowIndex].Cells["ID_HocVien"].Value.ToString();
                //txt_Search.Text = selectedHocVienID;
                // Cập nhật giá trị ID_HocVien vào TextBox (txt_Search) trong Form1
                //txt_Searchz = selectedHocVienID;
                //// Lấy ID_HocVien của học viên được chọn từ DataGridView
                //var selectedHocVienID = dtg_QLHOCVO.Rows[e.RowIndex].Cells["ID_HocVien"].Value.ToString();

                Form2 form2 = new Form2();  // Truyền ID_HocVien vào Form2
                form2.TimHLV(selectedHocVienID);  // Gọi phương thức để tải thông tin thẻ học viên
                form2.Show();  // Mở Form2
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }
        private void BindGrid(List<HocVien> listHocVien)
        {
            dtg_QLHOCVO.Rows.Clear();
    
            foreach (var item in listHocVien)
            {
                // Thêm dòng mới vào DataGridView
                int index = dtg_QLHOCVO.Rows.Add();
        
                // Gán giá trị cho các ô trong dòng hiện tại
                dtg_QLHOCVO.Rows[index].Cells[0].Value = item.ID_HocVien;
                dtg_QLHOCVO.Rows[index].Cells[1].Value = item.TenHocVien;
                dtg_QLHOCVO.Rows[index].Cells[2].Value = item.GioiTinh;
                dtg_QLHOCVO.Rows[index].Cells[3].Value = item.NgaySinh?.ToString("dd/MM/yyyy");
                dtg_QLHOCVO.Rows[index].Cells[4].Value = item.DiaChi;
                dtg_QLHOCVO.Rows[index].Cells[5].Value = item.SDT;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(txt_Search.Text.Length == 0)
                Load_QLHOCVO();
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormHV formHocVien = new FormHV(AddHocVienMoi);

            // Mở Form2
            formHocVien.ShowDialog();

        }
        private void AddHocVienMoi(HocVien hocVien)
        {
            // Thêm học viên vào DataGridView
            dtg_QLHOCVO.Rows.Add(hocVien.ID_HocVien, hocVien.TenHocVien, hocVien.GioiTinh, hocVien.NgaySinh.Value.ToString("dd/MM/yyyy"), hocVien.SDT, hocVien.DiaChi);
        }
    }

}

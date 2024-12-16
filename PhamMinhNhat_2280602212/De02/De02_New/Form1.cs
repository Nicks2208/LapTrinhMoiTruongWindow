using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //txt_NgayNhap.Value = DateTime.Parse(row.Cells["NgayNhap"].Value.ToString());
                cb_LoaiSP.Text = row.Cells["LoaiSP"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}

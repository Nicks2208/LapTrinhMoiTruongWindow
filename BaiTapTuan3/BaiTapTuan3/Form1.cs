using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan3
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStuden.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listStuden.SelectedItems[0];
                string last = lv1.SubItems[0].Text;
                string first = lv1.SubItems[1].Text;
                string phone = lv1.SubItems[2].Text;

                txtLast.Text = last;
                txtFirst.Text = first;
                txtPhone.Text = phone;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lv2 = new ListViewItem(txtLast.Text);
            lv2.SubItems.Add(txtFirst.Text);
            lv2.SubItems.Add(txtPhone.Text);
            listStuden.Items.Add(lv2);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon xoa muc da chon khong ", "Thong bao",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (listStuden.SelectedItems.Count > 0)
                {
                    listStuden.Items.Remove(listStuden.SelectedItems[0]);
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listStuden.SelectedItems.Count > 0)
            {
                ListViewItem lv3 = listStuden.SelectedItems[0];
                lv3.SubItems[0].Text = txtLast.Text;
                lv3.SubItems[1].Text = txtFirst.Text;
                lv3.SubItems[2].Text = txtPhone.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ", "Thong bao",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


    }
}


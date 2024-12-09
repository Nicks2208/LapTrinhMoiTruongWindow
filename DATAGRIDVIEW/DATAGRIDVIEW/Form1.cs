using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DATAGRIDVIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "A", Age = 20 });
            students.Add(new Student() { Id = 2, Name = "B", Age = 30 });
            students.Add(new Student() { Id = 3, Name = "C", Age = 31 });
            dtgStudent.DataSource = students;
        }


        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            //lấy dòng dữ liệu click
            DataGridViewRow row = dtgStudent.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAge.Text = row.Cells[2].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)
            };
            students.Add(s);
            dtgStudent.DataSource = new BindingList<Student>(students);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int slt_index = dtgStudent.SelectedCells[0].RowIndex;

            if (slt_index == -1)
            {
                MessageBox.Show("Vui long chon sinh vien de sua.");
                return;
            }

            Student std = students[slt_index];
            std.Id = int.Parse(txtId.Text);
            std.Name = txtName.Text;
            std.Age = int.Parse(txtAge.Text);

            dtgStudent.DataSource = null;
            dtgStudent.DataSource = students;

            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int slt_index = dtgStudent.SelectedCells[0].RowIndex;


            var confirmation = MessageBox.Show("Ban co muon xoa sinh vien nay khong?", "Chap nhan xoa", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.No)
            {
                return;
            }

            Student std = students[slt_index];
            students.Remove(std);

            dtgStudent.DataSource = null;
            dtgStudent.DataSource = students;

            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
        }
    }
}

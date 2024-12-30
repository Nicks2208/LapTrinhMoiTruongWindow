using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.BUS;
using Lab05.DAL.Entities;

namespace Lab05
{
    public partial class Form2 : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var listFacultys = facultyService.GetAll();
                FillFalcultyCombobox(listFacultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm binding list dữ liệu khoa vào combobox có tên hiển thị là tên khoa, giá trị là Mã khoa
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cb_Khoa.DataSource = listFacultys;
            this.cb_Khoa.DisplayMember = "FacultyName";
            this.cb_Khoa.ValueMember = "FacultyID";
        }

        private void cb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cb_Khoa.SelectedItem as Faculty;

            if (selectedFaculty != null)
            {
                var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                FillMajorCombobox(listMajor);
                var listStudents = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                BindGrid(listStudents);
            }
        }
        private void FillMajorCombobox(List<Major> listMajor)
        {
            listMajor = listMajor.Where(m => m != null).ToList();

            // Gắn dữ liệu vào combobox
            cb_ChuyenNghanh.DataSource = listMajor;
            cb_ChuyenNghanh.DisplayMember = "Name"; // Hiển thị thuộc tính "Name" của chuyên ngành
            cb_ChuyenNghanh.ValueMember = "MajorID"; // Giá trị thực tế là "MajorID"
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();

            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();

                dgvStudent.Rows[index].Cells[1].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[2].Value = item.FullName;

                if (item.Faculty != null)
                {
                    dgvStudent.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                }

                dgvStudent.Rows[index].Cells[4].Value = item.AverageScore.ToString();

                if (item.MajorID != null)
                {
                    dgvStudent.Rows[index].Cells[5].Value = item.Major.Name;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Vui lòng chọn một sinh viên");
            }
            if(cb_ChuyenNghanh.SelectedItem != null && cb_Khoa.SelectedItem != null)
            {
                Faculty selectedFaculty = cb_Khoa.SelectedItem as Faculty;
                Major selectedMajor = cb_ChuyenNghanh.SelectedItem as Major;
                if (selectedFaculty != null && selectedMajor != null)
                {
                    string studentID = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        Student student = studentService.FindById(studentID);
                        if (student != null)
                        {
                            student.MajorID = selectedMajor.MajorID;   
                            student.FacultyID = selectedFaculty.FacultyID;
                            studentService.InsertUpdate(student);
                            MessageBox.Show("Đăng ký chuyên nghành thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID sinh viên không hợp lệ");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn cả khoa và chuyên nghành");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chuyên nghành");
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                string studentID = row.Cells[1].Value.ToString();
                Student selectedStudent = studentService.FindById(studentID);
                if (selectedStudent != null)
                {
                    if (selectedStudent.FacultyID != null)
                    {
                        cb_Khoa.SelectedValue = selectedStudent.FacultyID;
                        var listMajors = majorService.GetAllByFaculty((int)selectedStudent.FacultyID);
                        FillMajorCombobox(listMajors);
                        if (selectedStudent.MajorID != null)
                        {
                            cb_ChuyenNghanh.SelectedValue = selectedStudent.MajorID;

                        }
                        else
                        {
                            cb_ChuyenNghanh.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sinh vien khong co khoa");
                }
            }
        }
    }
}

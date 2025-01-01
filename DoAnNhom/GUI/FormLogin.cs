using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.models;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_User.Text.Trim();
            string pass = txt_Pass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new Model1())
            {
                var admin = context.Administrators
                    .FirstOrDefault(a => a.Username == user && a.Pass == pass);

                if (admin != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    // Mở Form1
                    FormMain form1 = new FormMain();
                    form1.Show();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (dialogResult == DialogResult.No)
            //{
            //    // Nếu người dùng chọn "No", ngừng việc đóng form
            //    e.Cancel = true;
            //}
            //else
            //{
            //    // Nếu người dùng chọn "Yes", form sẽ đóng
            //    e.Cancel = false;
            //}
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = '*';
        }
    }
}

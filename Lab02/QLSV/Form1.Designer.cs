namespace QLSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TongNam = new System.Windows.Forms.TextBox();
            this.txt_TongNu = new System.Windows.Forms.TextBox();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.txt_DTB = new System.Windows.Forms.TextBox();
            this.cb_ChuyenNghanh = new System.Windows.Forms.ComboBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.dtg_qlsv = new System.Windows.Forms.DataGridView();
            this.col_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_XepHang = new System.Windows.Forms.ComboBox();
            this.btn_ThemSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_qlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Thông Tin Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm Trung Bình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Chuyên nghành";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Xếp hạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(881, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tổng SV Nam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1189, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nữ";
            // 
            // txt_TongNam
            // 
            this.txt_TongNam.Enabled = false;
            this.txt_TongNam.Location = new System.Drawing.Point(1029, 517);
            this.txt_TongNam.Name = "txt_TongNam";
            this.txt_TongNam.Size = new System.Drawing.Size(100, 22);
            this.txt_TongNam.TabIndex = 10;
            this.txt_TongNam.Text = "0";
            // 
            // txt_TongNu
            // 
            this.txt_TongNu.Enabled = false;
            this.txt_TongNu.Location = new System.Drawing.Point(1256, 517);
            this.txt_TongNu.Name = "txt_TongNu";
            this.txt_TongNu.Size = new System.Drawing.Size(100, 22);
            this.txt_TongNu.TabIndex = 11;
            this.txt_TongNu.Text = "0";
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nu.Location = new System.Drawing.Point(288, 253);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(52, 24);
            this.rb_Nu.TabIndex = 13;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nam.Location = new System.Drawing.Point(200, 253);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(64, 24);
            this.rb_Nam.TabIndex = 14;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_DTB
            // 
            this.txt_DTB.Location = new System.Drawing.Point(200, 313);
            this.txt_DTB.Name = "txt_DTB";
            this.txt_DTB.Size = new System.Drawing.Size(108, 22);
            this.txt_DTB.TabIndex = 15;
            // 
            // cb_ChuyenNghanh
            // 
            this.cb_ChuyenNghanh.FormattingEnabled = true;
            this.cb_ChuyenNghanh.Location = new System.Drawing.Point(200, 373);
            this.cb_ChuyenNghanh.Name = "cb_ChuyenNghanh";
            this.cb_ChuyenNghanh.Size = new System.Drawing.Size(188, 24);
            this.cb_ChuyenNghanh.TabIndex = 16;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(200, 145);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(223, 22);
            this.txt_MSSV.TabIndex = 17;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(200, 200);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(223, 22);
            this.txt_HoTen.TabIndex = 18;
            // 
            // dtg_qlsv
            // 
            this.dtg_qlsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_qlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_qlsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MSSV,
            this.col_HoTen,
            this.col_GioiTinh,
            this.col_DTB,
            this.col_Khoa});
            this.dtg_qlsv.Location = new System.Drawing.Point(593, 145);
            this.dtg_qlsv.Name = "dtg_qlsv";
            this.dtg_qlsv.RowHeadersWidth = 51;
            this.dtg_qlsv.RowTemplate.Height = 24;
            this.dtg_qlsv.Size = new System.Drawing.Size(785, 351);
            this.dtg_qlsv.TabIndex = 19;
            this.dtg_qlsv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_qlsv_CellContentClick);
            // 
            // col_MSSV
            // 
            this.col_MSSV.HeaderText = "MSSV";
            this.col_MSSV.MinimumWidth = 6;
            this.col_MSSV.Name = "col_MSSV";
            // 
            // col_HoTen
            // 
            this.col_HoTen.HeaderText = "Họ Tên";
            this.col_HoTen.MinimumWidth = 6;
            this.col_HoTen.Name = "col_HoTen";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // col_DTB
            // 
            this.col_DTB.HeaderText = "ĐTB";
            this.col_DTB.MinimumWidth = 6;
            this.col_DTB.Name = "col_DTB";
            // 
            // col_Khoa
            // 
            this.col_Khoa.HeaderText = "Khoa";
            this.col_Khoa.MinimumWidth = 6;
            this.col_Khoa.Name = "col_Khoa";
            // 
            // cb_XepHang
            // 
            this.cb_XepHang.FormattingEnabled = true;
            this.cb_XepHang.Location = new System.Drawing.Point(710, 92);
            this.cb_XepHang.Name = "cb_XepHang";
            this.cb_XepHang.Size = new System.Drawing.Size(188, 24);
            this.cb_XepHang.TabIndex = 20;
            // 
            // btn_ThemSua
            // 
            this.btn_ThemSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSua.Location = new System.Drawing.Point(64, 487);
            this.btn_ThemSua.Name = "btn_ThemSua";
            this.btn_ThemSua.Size = new System.Drawing.Size(157, 32);
            this.btn_ThemSua.TabIndex = 21;
            this.btn_ThemSua.Text = "Thêm/Sửa";
            this.btn_ThemSua.UseVisualStyleBackColor = true;
            this.btn_ThemSua.Click += new System.EventHandler(this.btn_ThemSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(306, 487);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(157, 32);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(1279, 91);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(99, 25);
            this.btn_TimKiem.TabIndex = 23;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(1106, 94);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 561);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_ThemSua);
            this.Controls.Add(this.cb_XepHang);
            this.Controls.Add(this.dtg_qlsv);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.cb_ChuyenNghanh);
            this.Controls.Add(this.txt_DTB);
            this.Controls.Add(this.rb_Nam);
            this.Controls.Add(this.rb_Nu);
            this.Controls.Add(this.txt_TongNu);
            this.Controls.Add(this.txt_TongNam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_qlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TongNam;
        private System.Windows.Forms.TextBox txt_TongNu;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.TextBox txt_DTB;
        private System.Windows.Forms.ComboBox cb_ChuyenNghanh;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.DataGridView dtg_qlsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Khoa;
        private System.Windows.Forms.ComboBox cb_XepHang;
        private System.Windows.Forms.Button btn_ThemSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider err;
    }
}


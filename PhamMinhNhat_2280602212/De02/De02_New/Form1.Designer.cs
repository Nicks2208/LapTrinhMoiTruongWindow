namespace De02
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
            System.Windows.Forms.Button btn_Them;
            System.Windows.Forms.Button btn_Sua;
            System.Windows.Forms.Button btn_Xoa;
            System.Windows.Forms.Button btn_Luu;
            System.Windows.Forms.Button btn_KhongLuu;
            System.Windows.Forms.Button btn_Thoat;
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_SanPham = new System.Windows.Forms.DataGridView();
            this.col_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.cb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            btn_Them = new System.Windows.Forms.Button();
            btn_Sua = new System.Windows.Forms.Button();
            btn_Xoa = new System.Windows.Forms.Button();
            btn_Luu = new System.Windows.Forms.Button();
            btn_KhongLuu = new System.Windows.Forms.Button();
            btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Them.Location = new System.Drawing.Point(43, 461);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(120, 34);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Sua.Location = new System.Drawing.Point(206, 461);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new System.Drawing.Size(120, 34);
            btn_Sua.TabIndex = 14;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Xoa.Location = new System.Drawing.Point(360, 461);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new System.Drawing.Size(120, 34);
            btn_Xoa.TabIndex = 15;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            btn_Luu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Luu.Location = new System.Drawing.Point(516, 461);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new System.Drawing.Size(120, 34);
            btn_Luu.TabIndex = 16;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_KhongLuu
            // 
            btn_KhongLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_KhongLuu.Location = new System.Drawing.Point(665, 461);
            btn_KhongLuu.Name = "btn_KhongLuu";
            btn_KhongLuu.Size = new System.Drawing.Size(120, 34);
            btn_KhongLuu.TabIndex = 17;
            btn_KhongLuu.Text = "Không Lưu";
            btn_KhongLuu.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Thoat.Location = new System.Drawing.Point(820, 461);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new System.Drawing.Size(120, 34);
            btn_Thoat.TabIndex = 18;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // dtg_SanPham
            // 
            this.dtg_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSP,
            this.col_TenSP,
            this.col_NgayNhap,
            this.col_LoaiSP});
            this.dtg_SanPham.Location = new System.Drawing.Point(11, 164);
            this.dtg_SanPham.Name = "dtg_SanPham";
            this.dtg_SanPham.RowHeadersWidth = 51;
            this.dtg_SanPham.RowTemplate.Height = 24;
            this.dtg_SanPham.Size = new System.Drawing.Size(572, 273);
            this.dtg_SanPham.TabIndex = 1;
            this.dtg_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_MaSP
            // 
            this.col_MaSP.HeaderText = "Mã SP";
            this.col_MaSP.MinimumWidth = 6;
            this.col_MaSP.Name = "col_MaSP";
            // 
            // col_TenSP
            // 
            this.col_TenSP.HeaderText = "Tên Sản Phẩm";
            this.col_TenSP.MinimumWidth = 6;
            this.col_TenSP.Name = "col_TenSP";
            // 
            // col_NgayNhap
            // 
            this.col_NgayNhap.HeaderText = "Ngày Nhập";
            this.col_NgayNhap.MinimumWidth = 6;
            this.col_NgayNhap.Name = "col_NgayNhap";
            // 
            // col_LoaiSP
            // 
            this.col_LoaiSP.HeaderText = "Loại SP";
            this.col_LoaiSP.MinimumWidth = 6;
            this.col_LoaiSP.Name = "col_LoaiSP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại SP:";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(751, 183);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(156, 22);
            this.txt_MaSP.TabIndex = 6;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(751, 229);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(224, 22);
            this.txt_TenSP.TabIndex = 7;
            // 
            // cb_LoaiSP
            // 
            this.cb_LoaiSP.FormattingEnabled = true;
            this.cb_LoaiSP.Location = new System.Drawing.Point(751, 322);
            this.cb_LoaiSP.Name = "cb_LoaiSP";
            this.cb_LoaiSP.Size = new System.Drawing.Size(121, 24);
            this.cb_LoaiSP.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(768, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search.Location = new System.Drawing.Point(258, 101);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 33);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(43, 106);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(182, 22);
            this.txt_Search.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 522);
            this.Controls.Add(btn_Thoat);
            this.Controls.Add(btn_KhongLuu);
            this.Controls.Add(btn_Luu);
            this.Controls.Add(btn_Xoa);
            this.Controls.Add(btn_Sua);
            this.Controls.Add(btn_Them);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_LoaiSP);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_SanPham);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.ComboBox cb_LoaiSP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}


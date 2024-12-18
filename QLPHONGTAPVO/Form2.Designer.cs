namespace QLPHONGTAPVO
{
    partial class Form2
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
            this.dtg_HLV = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.col_IDHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinhHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinhHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChiHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HLV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_HLV
            // 
            this.dtg_HLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_HLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDHLV,
            this.col_TenHLV,
            this.col_GioiTinhHLV,
            this.col_NgaySinhHLV,
            this.col_SDT,
            this.col_ChuyenMon,
            this.col_DiaChiHLV});
            this.dtg_HLV.Location = new System.Drawing.Point(12, 75);
            this.dtg_HLV.Name = "dtg_HLV";
            this.dtg_HLV.RowHeadersWidth = 51;
            this.dtg_HLV.RowTemplate.Height = 24;
            this.dtg_HLV.Size = new System.Drawing.Size(780, 376);
            this.dtg_HLV.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(868, 75);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 42);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(868, 177);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 42);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(868, 284);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 42);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(868, 399);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(110, 42);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông Tin HLV";
            // 
            // col_IDHLV
            // 
            this.col_IDHLV.HeaderText = "ID HLV";
            this.col_IDHLV.MinimumWidth = 6;
            this.col_IDHLV.Name = "col_IDHLV";
            // 
            // col_TenHLV
            // 
            this.col_TenHLV.HeaderText = "Tên HLV";
            this.col_TenHLV.MinimumWidth = 6;
            this.col_TenHLV.Name = "col_TenHLV";
            // 
            // col_GioiTinhHLV
            // 
            this.col_GioiTinhHLV.HeaderText = "Giới tính";
            this.col_GioiTinhHLV.MinimumWidth = 6;
            this.col_GioiTinhHLV.Name = "col_GioiTinhHLV";
            // 
            // col_NgaySinhHLV
            // 
            this.col_NgaySinhHLV.HeaderText = "Ngày Sinh";
            this.col_NgaySinhHLV.MinimumWidth = 6;
            this.col_NgaySinhHLV.Name = "col_NgaySinhHLV";
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "SDT";
            this.col_SDT.MinimumWidth = 6;
            this.col_SDT.Name = "col_SDT";
            // 
            // col_ChuyenMon
            // 
            this.col_ChuyenMon.HeaderText = "Chuyên Môn";
            this.col_ChuyenMon.MinimumWidth = 6;
            this.col_ChuyenMon.Name = "col_ChuyenMon";
            // 
            // col_DiaChiHLV
            // 
            this.col_DiaChiHLV.HeaderText = "Địa Chỉ";
            this.col_DiaChiHLV.MinimumWidth = 6;
            this.col_DiaChiHLV.Name = "col_DiaChiHLV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtg_HLV);
            this.Name = "Form2";
            this.Text = "Thông tin HLV";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_HLV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinhHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinhHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChiHLV;
    }
}
namespace QLPHONGTAPVO
{
    partial class FormLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLopHoc));
            this.label7 = new System.Windows.Forms.Label();
            this.cb_TenHLV = new System.Windows.Forms.ComboBox();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_ThoiGianHoc = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_IDLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Chọn HLV:";
            // 
            // cb_TenHLV
            // 
            this.cb_TenHLV.FormattingEnabled = true;
            this.cb_TenHLV.Location = new System.Drawing.Point(177, 200);
            this.cb_TenHLV.Name = "cb_TenHLV";
            this.cb_TenHLV.Size = new System.Drawing.Size(157, 24);
            this.cb_TenHLV.TabIndex = 35;
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.BackColor = System.Drawing.Color.Salmon;
            this.btn_BoQua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoQua.Location = new System.Drawing.Point(519, 363);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(160, 49);
            this.btn_BoQua.TabIndex = 32;
            this.btn_BoQua.Text = "Bỏ Qua";
            this.btn_BoQua.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them.Location = new System.Drawing.Point(191, 363);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(161, 49);
            this.btn_Them.TabIndex = 31;
            this.btn_Them.Text = "Đồng Ý";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_ThoiGianHoc
            // 
            this.txt_ThoiGianHoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_ThoiGianHoc.Location = new System.Drawing.Point(177, 267);
            this.txt_ThoiGianHoc.Name = "txt_ThoiGianHoc";
            this.txt_ThoiGianHoc.Size = new System.Drawing.Size(392, 22);
            this.txt_ThoiGianHoc.TabIndex = 29;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_TenLop.Location = new System.Drawing.Point(177, 139);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(270, 22);
            this.txt_TenLop.TabIndex = 27;
            // 
            // txt_IDLop
            // 
            this.txt_IDLop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_IDLop.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_IDLop.Location = new System.Drawing.Point(177, 86);
            this.txt_IDLop.Name = "txt_IDLop";
            this.txt_IDLop.Size = new System.Drawing.Size(192, 22);
            this.txt_IDLop.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thời gian học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::QLPHONGTAPVO.Properties.Resources.background_GTAVN;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Lớp học:";
            // 
            // FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTAPVO.Properties.Resources.hoc_muay_thai_tphcm_tai_Hit_Muay_Thai_Fitness_Center;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_TenHLV);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_ThoiGianHoc);
            this.Controls.Add(this.txt_TenLop);
            this.Controls.Add(this.txt_IDLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLopHoc";
            this.Text = "Thông tin lớp học";
            this.Load += new System.EventHandler(this.FormLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_TenHLV;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_ThoiGianHoc;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_IDLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
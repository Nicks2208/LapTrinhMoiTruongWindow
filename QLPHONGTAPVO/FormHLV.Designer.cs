namespace QLPHONGTAPVO
{
    partial class FormHLV
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
            this.label7 = new System.Windows.Forms.Label();
            this.combo_ChuyenMon = new System.Windows.Forms.ComboBox();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenHLV = new System.Windows.Forms.TextBox();
            this.txt_IDHLV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Chuyên Môn:";
            // 
            // combo_ChuyenMon
            // 
            this.combo_ChuyenMon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.combo_ChuyenMon.FormattingEnabled = true;
            this.combo_ChuyenMon.Items.AddRange(new object[] {
            "Karate",
            "Taekwondo"});
            this.combo_ChuyenMon.Location = new System.Drawing.Point(665, 180);
            this.combo_ChuyenMon.Name = "combo_ChuyenMon";
            this.combo_ChuyenMon.Size = new System.Drawing.Size(144, 24);
            this.combo_ChuyenMon.TabIndex = 31;
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rb_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nu.Location = new System.Drawing.Point(740, 69);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(57, 27);
            this.rb_Nu.TabIndex = 46;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = false;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rb_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nam.Location = new System.Drawing.Point(636, 69);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(70, 27);
            this.rb_Nam.TabIndex = 45;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = false;
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.BackColor = System.Drawing.Color.Salmon;
            this.btn_BoQua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoQua.Location = new System.Drawing.Point(536, 348);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(160, 49);
            this.btn_BoQua.TabIndex = 44;
            this.btn_BoQua.Text = "Bỏ Qua";
            this.btn_BoQua.UseVisualStyleBackColor = false;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
            // 
            // btn_DongY
            // 
            this.btn_DongY.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_DongY.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DongY.Location = new System.Drawing.Point(208, 348);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(161, 49);
            this.btn_DongY.TabIndex = 43;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.UseVisualStyleBackColor = false;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click_1);
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Location = new System.Drawing.Point(651, 124);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dt_NgaySinh.TabIndex = 42;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_DiaChi.Location = new System.Drawing.Point(154, 243);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(392, 22);
            this.txt_DiaChi.TabIndex = 41;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_SDT.Location = new System.Drawing.Point(154, 183);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(227, 22);
            this.txt_SDT.TabIndex = 40;
            // 
            // txt_TenHLV
            // 
            this.txt_TenHLV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TenHLV.Location = new System.Drawing.Point(154, 126);
            this.txt_TenHLV.Name = "txt_TenHLV";
            this.txt_TenHLV.Size = new System.Drawing.Size(270, 22);
            this.txt_TenHLV.TabIndex = 39;
            // 
            // txt_IDHLV
            // 
            this.txt_IDHLV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_IDHLV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_IDHLV.Location = new System.Drawing.Point(154, 73);
            this.txt_IDHLV.Name = "txt_IDHLV";
            this.txt_IDHLV.Size = new System.Drawing.Size(192, 22);
            this.txt_IDHLV.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(518, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày Sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::QLPHONGTAPVO.Properties.Resources.background_GTAVN;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên HLV:";
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
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID HLV:";
            // 
            // FormHLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTAPVO.Properties.Resources.vlcsnap_2023_05_31_12h56m52s635_copy;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.rb_Nu);
            this.Controls.Add(this.rb_Nam);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenHLV);
            this.Controls.Add(this.txt_IDHLV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_ChuyenMon);
            this.Controls.Add(this.label7);
            this.Name = "FormHLV";
            this.Text = "Huấn Luyện Viên";
            this.Load += new System.EventHandler(this.FormHLV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_ChuyenMon;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenHLV;
        private System.Windows.Forms.TextBox txt_IDHLV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
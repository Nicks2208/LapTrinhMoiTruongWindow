namespace TruyenDuLieu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMSNV = new TextBox();
            txtTen = new TextBox();
            txtLuong = new TextBox();
            btn_Dongy = new Button();
            btn_boqua = new Button();
            //SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "MSNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 145);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 212);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Lương căn bản";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(254, 78);
            txtMSNV.Margin = new Padding(3, 4, 3, 4);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(299, 27);
            txtMSNV.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(254, 145);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(299, 27);
            txtTen.TabIndex = 1;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(254, 212);
            txtLuong.Margin = new Padding(3, 4, 3, 4);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(299, 27);
            txtLuong.TabIndex = 1;
            // 
            // btn_Dongy
            // 
            btn_Dongy.Location = new Point(254, 301);
            btn_Dongy.Margin = new Padding(3, 4, 3, 4);
            btn_Dongy.Name = "btn_Dongy";
            btn_Dongy.Size = new Size(92, 44);
            btn_Dongy.TabIndex = 2;
            btn_Dongy.Text = "Đồng ý";
            btn_Dongy.UseVisualStyleBackColor = true;
            btn_Dongy.Click += btn_Dongy_Click;
            // 
            // btn_boqua
            // 
            btn_boqua.Location = new Point(453, 301);
            btn_boqua.Margin = new Padding(3, 4, 3, 4);
            btn_boqua.Name = "btn_boqua";
            btn_boqua.Size = new Size(100, 44);
            btn_boqua.TabIndex = 3;
            btn_boqua.Text = "Bỏ qua";
            btn_boqua.UseVisualStyleBackColor = true;
            btn_boqua.Click += btn_boqua_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btn_boqua);
            Controls.Add(btn_Dongy);
            Controls.Add(txtLuong);
            Controls.Add(txtTen);
            Controls.Add(txtMSNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btn_Dongy;
        private System.Windows.Forms.Button btn_boqua;
    }
}
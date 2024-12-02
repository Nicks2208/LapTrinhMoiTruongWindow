namespace BaiTap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ lót:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(69, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(113, 102);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(415, 20);
            this.txtHo.TabIndex = 2;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTen.Location = new System.Drawing.Point(113, 145);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(415, 20);
            this.txtTen.TabIndex = 3;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen1_TextChanged);
            // 
            // btnHo
            // 
            this.btnHo.ForeColor = System.Drawing.Color.Black;
            this.btnHo.Location = new System.Drawing.Point(127, 209);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(75, 23);
            this.btnHo.TabIndex = 4;
            this.btnHo.Text = "Họ Lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTen
            // 
            this.btnTen.ForeColor = System.Drawing.Color.Black;
            this.btnTen.Location = new System.Drawing.Point(273, 209);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 5;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.ForeColor = System.Drawing.Color.Black;
            this.btnHoTen.Location = new System.Drawing.Point(423, 209);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoTen.TabIndex = 6;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.ForeColor = System.Drawing.Color.Black;
            this.btnKetThuc.Location = new System.Drawing.Point(246, 256);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(137, 23);
            this.btnKetThuc.TabIndex = 7;
            this.btnKetThuc.Text = "Thoát Chương Trình";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(211, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHoTen.Location = new System.Drawing.Point(-3, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(606, 79);
            this.lblHoTen.TabIndex = 9;
            this.lblHoTen.AutoSizeChanged += new System.EventHandler(this.label4_AutoSizeChanged);
            this.lblHoTen.BackColorChanged += new System.EventHandler(this.label4_BackColorChanged);
            this.lblHoTen.Click += new System.EventHandler(this.label4_Click);
            this.lblHoTen.DoubleClick += new System.EventHandler(this.lblHoTen_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 291);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bài Tập Họ Tên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoTen;
    }
}


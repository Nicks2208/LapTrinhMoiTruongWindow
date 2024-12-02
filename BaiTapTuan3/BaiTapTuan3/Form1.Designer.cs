namespace BaiTapTuan3
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pham",
            "Minh Nhat",
            "0929811263"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyen",
            "Van Toan",
            "0906123589"}, -1);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.KetThuc = new System.Windows.Forms.Button();
            this.clnLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnFist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listStuden = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(509, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(509, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(509, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 351);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(391, 351);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(200, 351);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(512, 115);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(172, 22);
            this.txtLast.TabIndex = 6;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(512, 205);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(172, 22);
            this.txtFirst.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(512, 292);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(172, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // KetThuc
            // 
            this.KetThuc.Location = new System.Drawing.Point(512, 351);
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.Size = new System.Drawing.Size(172, 23);
            this.KetThuc.TabIndex = 7;
            this.KetThuc.Text = "Thoát chương trình";
            this.KetThuc.UseVisualStyleBackColor = true;
            this.KetThuc.Click += new System.EventHandler(this.button1_Click);
            // 
            // clnLast
            // 
            this.clnLast.Text = "LastName";
            this.clnLast.Width = 120;
            // 
            // clnFist
            // 
            this.clnFist.Text = "FistName";
            this.clnFist.Width = 120;
            // 
            // clnPhone
            // 
            this.clnPhone.Text = "Phone";
            this.clnPhone.Width = 120;
            // 
            // listStuden
            // 
            this.listStuden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnLast,
            this.clnFist,
            this.clnPhone});
            this.listStuden.FullRowSelect = true;
            this.listStuden.GridLines = true;
            this.listStuden.HideSelection = false;
            this.listStuden.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listStuden.Location = new System.Drawing.Point(27, 78);
            this.listStuden.Name = "listStuden";
            this.listStuden.Size = new System.Drawing.Size(439, 236);
            this.listStuden.TabIndex = 0;
            this.listStuden.UseCompatibleStateImageBehavior = false;
            this.listStuden.View = System.Windows.Forms.View.Details;
            this.listStuden.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 426);
            this.Controls.Add(this.KetThuc);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listStuden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button KetThuc;
        private System.Windows.Forms.ColumnHeader clnLast;
        private System.Windows.Forms.ColumnHeader clnFist;
        private System.Windows.Forms.ColumnHeader clnPhone;
        private System.Windows.Forms.ListView listStuden;
    }
}


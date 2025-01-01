using System.Windows.Forms;

namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dtg_QLHOCVO = new System.Windows.Forms.DataGridView();
            this.col_IDHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_SuaHV = new System.Windows.Forms.Button();
            this.btn_XoaHV = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.pb_Refesh = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IDHV = new System.Windows.Forms.TextBox();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.txt_TenHV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_ThemHV = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dtg_HLV = new System.Windows.Forms.DataGridView();
            this.col_IDHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinhHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinhHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDTHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChiHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_XoaHLV = new System.Windows.Forms.Button();
            this.btn_SuaHLV = new System.Windows.Forms.Button();
            this.btn_ThemHLV = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_XoaLop = new System.Windows.Forms.Button();
            this.btn_SuaLop = new System.Windows.Forms.Button();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_TimKiemLop = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_tongsolophoc = new System.Windows.Forms.Label();
            this.dtgLopHoc = new System.Windows.Forms.DataGridView();
            this.col_IDLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDHLV_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThoiGianHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_TenHLV = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_IDLop = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_ThoiGianHoc = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dtg_TT_HLV = new System.Windows.Forms.DataGridView();
            this.col_TT_IDHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TT_TenHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TT_LuongHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_TT_HV = new System.Windows.Forms.DataGridView();
            this.col_TT_IDHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TT_TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TT_HocPhiHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_QLHOCVO)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HLV)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLopHoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TT_HLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TT_HV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_QLHOCVO
            // 
            this.dtg_QLHOCVO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_QLHOCVO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_QLHOCVO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDHV,
            this.col_TenHV,
            this.col_GioiTinh,
            this.col_NgaySinh,
            this.col_SDT,
            this.col_DiaChi,
            this.col_Lop});
            this.dtg_QLHOCVO.Location = new System.Drawing.Point(3, 91);
            this.dtg_QLHOCVO.Name = "dtg_QLHOCVO";
            this.dtg_QLHOCVO.RowHeadersWidth = 51;
            this.dtg_QLHOCVO.RowTemplate.Height = 24;
            this.dtg_QLHOCVO.Size = new System.Drawing.Size(805, 403);
            this.dtg_QLHOCVO.TabIndex = 2;
            this.dtg_QLHOCVO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_QLHOCVO_CellContentClick);
            // 
            // col_IDHV
            // 
            this.col_IDHV.HeaderText = "ID Học Viên";
            this.col_IDHV.MinimumWidth = 6;
            this.col_IDHV.Name = "col_IDHV";
            // 
            // col_TenHV
            // 
            this.col_TenHV.HeaderText = "Tên Học Viên";
            this.col_TenHV.MinimumWidth = 6;
            this.col_TenHV.Name = "col_TenHV";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.HeaderText = "Ngày Sinh";
            this.col_NgaySinh.MinimumWidth = 6;
            this.col_NgaySinh.Name = "col_NgaySinh";
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "SDT";
            this.col_SDT.MinimumWidth = 6;
            this.col_SDT.Name = "col_SDT";
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.HeaderText = "Địa Chỉ";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_Lop
            // 
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.MinimumWidth = 6;
            this.col_Lop.Name = "col_Lop";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(21, 36);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(214, 23);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_SuaHV
            // 
            this.btn_SuaHV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_SuaHV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaHV.Location = new System.Drawing.Point(265, 514);
            this.btn_SuaHV.Name = "btn_SuaHV";
            this.btn_SuaHV.Size = new System.Drawing.Size(113, 32);
            this.btn_SuaHV.TabIndex = 9;
            this.btn_SuaHV.Text = "Sửa";
            this.btn_SuaHV.UseVisualStyleBackColor = false;
            this.btn_SuaHV.Click += new System.EventHandler(this.btn_SuaHV_Click);
            // 
            // btn_XoaHV
            // 
            this.btn_XoaHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaHV.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_XoaHV.Location = new System.Drawing.Point(474, 514);
            this.btn_XoaHV.Name = "btn_XoaHV";
            this.btn_XoaHV.Size = new System.Drawing.Size(113, 32);
            this.btn_XoaHV.TabIndex = 10;
            this.btn_XoaHV.Text = "Xóa";
            this.btn_XoaHV.UseVisualStyleBackColor = false;
            this.btn_XoaHV.Click += new System.EventHandler(this.btn_XoaHV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 157);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.z6180176868037_e35b7b2c4479869e3a2791acdd47b843;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1163, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 155);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(431, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hotline : (+84)929811263";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(371, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "30A Lê Quang Định, quận Bình Thạnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(467, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Muay Fit Center";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.z6180176868037_e35b7b2c4479869e3a2791acdd47b843;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Controls.Add(this.tabPage3);
            this.tabCtrl.Controls.Add(this.tabPage4);
            this.tabCtrl.Controls.Add(this.tabPage5);
            this.tabCtrl.ImageList = this.imageList1;
            this.tabCtrl.Location = new System.Drawing.Point(0, 154);
            this.tabCtrl.Multiline = true;
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1342, 614);
            this.tabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCtrl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.pb_Refesh);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtg_QLHOCVO);
            this.tabPage1.Controls.Add(this.btn_ThemHV);
            this.tabPage1.Controls.Add(this.btn_SuaHV);
            this.tabPage1.Controls.Add(this.btn_XoaHV);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1334, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Học Viên";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label25.Location = new System.Drawing.Point(53, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 22);
            this.label25.TabIndex = 22;
            this.label25.Text = "Refesh Data";
            // 
            // pb_Refesh
            // 
            this.pb_Refesh.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_Refesh.BackgroundImage = global::GUI.Properties.Resources.reload;
            this.pb_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Refesh.Location = new System.Drawing.Point(8, 54);
            this.pb_Refesh.Name = "pb_Refesh";
            this.pb_Refesh.Size = new System.Drawing.Size(39, 32);
            this.pb_Refesh.TabIndex = 21;
            this.pb_Refesh.TabStop = false;
            this.pb_Refesh.Click += new System.EventHandler(this.pb_RefeshHV_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::GUI.Properties.Resources.next;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(215, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 40);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::GUI.Properties.Resources.arrow_right2;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(717, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(101, 70);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(265, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 79);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(295, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thông tin HLV";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = global::GUI.Properties.Resources._30_4_1_5;
            this.btn_Search.Location = new System.Drawing.Point(248, 27);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 37);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox17);
            this.groupBox1.Controls.Add(this.txt_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_Lop);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_IDHV);
            this.groupBox1.Controls.Add(this.rb_Nu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rb_Nam);
            this.groupBox1.Controls.Add(this.txt_TenHV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(833, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 546);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_NgaySinh.Enabled = false;
            this.txt_NgaySinh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.Location = new System.Drawing.Point(129, 361);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(227, 26);
            this.txt_NgaySinh.TabIndex = 37;
            // 
            // txt_Lop
            // 
            this.txt_Lop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Lop.Enabled = false;
            this.txt_Lop.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lop.Location = new System.Drawing.Point(129, 501);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(227, 26);
            this.txt_Lop.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(19, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 35;
            this.label10.Text = "Mã Học Viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Lớp:";
            // 
            // txt_IDHV
            // 
            this.txt_IDHV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_IDHV.Enabled = false;
            this.txt_IDHV.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDHV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_IDHV.Location = new System.Drawing.Point(164, 224);
            this.txt_IDHV.Name = "txt_IDHV";
            this.txt_IDHV.Size = new System.Drawing.Size(192, 26);
            this.txt_IDHV.TabIndex = 26;
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rb_Nu.Enabled = false;
            this.rb_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nu.Location = new System.Drawing.Point(231, 314);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(57, 27);
            this.rb_Nu.TabIndex = 32;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(19, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày Sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.UseWaitCursor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(129, 463);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(353, 23);
            this.txt_DiaChi.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(19, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên Học Viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Địa Chỉ:";
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rb_Nam.Enabled = false;
            this.rb_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nam.Location = new System.Drawing.Point(129, 314);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(70, 27);
            this.rb_Nam.TabIndex = 31;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = false;
            // 
            // txt_TenHV
            // 
            this.txt_TenHV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_TenHV.Enabled = false;
            this.txt_TenHV.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHV.Location = new System.Drawing.Point(168, 271);
            this.txt_TenHV.Name = "txt_TenHV";
            this.txt_TenHV.Size = new System.Drawing.Size(270, 26);
            this.txt_TenHV.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "SDT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Giới tính:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(129, 411);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(227, 26);
            this.txt_SDT.TabIndex = 28;
            // 
            // btn_ThemHV
            // 
            this.btn_ThemHV.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ThemHV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHV.Image = global::GUI.Properties.Resources.coach;
            this.btn_ThemHV.Location = new System.Drawing.Point(67, 514);
            this.btn_ThemHV.Name = "btn_ThemHV";
            this.btn_ThemHV.Size = new System.Drawing.Size(113, 32);
            this.btn_ThemHV.TabIndex = 8;
            this.btn_ThemHV.Text = "Thêm";
            this.btn_ThemHV.UseVisualStyleBackColor = false;
            this.btn_ThemHV.Click += new System.EventHandler(this.btn_ThemHV_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dtg_HLV);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btn_XoaHLV);
            this.tabPage2.Controls.Add(this.btn_SuaHLV);
            this.tabPage2.Controls.Add(this.btn_ThemHLV);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1334, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Huấn luyện viên";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::GUI.Properties.Resources.arrow_right2;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(721, 28);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 70);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI.Properties.Resources.coach__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(155, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 63);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GUI.Properties.Resources.coach__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(542, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 63);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(828, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 487);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin HLV";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(151, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(151, 356);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 26);
            this.textBox2.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Mã HLV:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 23);
            this.label13.TabIndex = 34;
            this.label13.Text = "Chuyên môn:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.Location = new System.Drawing.Point(151, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 26);
            this.textBox3.TabIndex = 26;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(266, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 27);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nữ";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(6, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ngày Sinh:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label14.UseWaitCursor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(112, 304);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(353, 23);
            this.textBox4.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Location = new System.Drawing.Point(6, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "Tên HLV:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 23);
            this.label16.TabIndex = 25;
            this.label16.Text = "Địa Chỉ:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(151, 142);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 27);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nam";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(151, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(270, 26);
            this.textBox5.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 23);
            this.label17.TabIndex = 24;
            this.label17.Text = "SDT:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 23);
            this.label18.TabIndex = 22;
            this.label18.Text = "Giới tính:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(151, 252);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 26);
            this.textBox6.TabIndex = 28;
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
            this.col_SDTHLV,
            this.col_ChuyenMon,
            this.col_DiaChiHLV});
            this.dtg_HLV.Location = new System.Drawing.Point(6, 104);
            this.dtg_HLV.Name = "dtg_HLV";
            this.dtg_HLV.RowHeadersWidth = 51;
            this.dtg_HLV.RowTemplate.Height = 24;
            this.dtg_HLV.Size = new System.Drawing.Size(766, 382);
            this.dtg_HLV.TabIndex = 7;
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
            // col_SDTHLV
            // 
            this.col_SDTHLV.HeaderText = "SDT";
            this.col_SDTHLV.MinimumWidth = 6;
            this.col_SDTHLV.Name = "col_SDTHLV";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 42);
            this.label11.TabIndex = 12;
            this.label11.Text = "Danh sách HLV";
            // 
            // btn_XoaHLV
            // 
            this.btn_XoaHLV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHLV.Location = new System.Drawing.Point(474, 496);
            this.btn_XoaHLV.Name = "btn_XoaHLV";
            this.btn_XoaHLV.Size = new System.Drawing.Size(110, 42);
            this.btn_XoaHLV.TabIndex = 10;
            this.btn_XoaHLV.Text = "Xóa";
            this.btn_XoaHLV.UseVisualStyleBackColor = true;
            this.btn_XoaHLV.Click += new System.EventHandler(this.btn_XoaHLV_Click);
            // 
            // btn_SuaHLV
            // 
            this.btn_SuaHLV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaHLV.Location = new System.Drawing.Point(276, 496);
            this.btn_SuaHLV.Name = "btn_SuaHLV";
            this.btn_SuaHLV.Size = new System.Drawing.Size(110, 42);
            this.btn_SuaHLV.TabIndex = 9;
            this.btn_SuaHLV.Text = "Sửa";
            this.btn_SuaHLV.UseVisualStyleBackColor = true;
            this.btn_SuaHLV.Click += new System.EventHandler(this.btn_SuaHLV_Click);
            // 
            // btn_ThemHLV
            // 
            this.btn_ThemHLV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHLV.Location = new System.Drawing.Point(59, 496);
            this.btn_ThemHLV.Name = "btn_ThemHLV";
            this.btn_ThemHLV.Size = new System.Drawing.Size(110, 42);
            this.btn_ThemHLV.TabIndex = 8;
            this.btn_ThemHLV.Text = "Thêm";
            this.btn_ThemHLV.UseVisualStyleBackColor = true;
            this.btn_ThemHLV.Click += new System.EventHandler(this.btn_ThemHLV_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Controls.Add(this.btn_XoaLop);
            this.tabPage3.Controls.Add(this.btn_SuaLop);
            this.tabPage3.Controls.Add(this.btn_ThemLop);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dtgLopHoc);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.pictureBox15);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage3.Size = new System.Drawing.Size(1334, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lớp học";
            // 
            // btn_XoaLop
            // 
            this.btn_XoaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLop.Location = new System.Drawing.Point(441, 489);
            this.btn_XoaLop.Name = "btn_XoaLop";
            this.btn_XoaLop.Size = new System.Drawing.Size(110, 42);
            this.btn_XoaLop.TabIndex = 25;
            this.btn_XoaLop.Text = "Xóa";
            this.btn_XoaLop.UseVisualStyleBackColor = true;
            this.btn_XoaLop.Click += new System.EventHandler(this.btn_XoaLop_Click);
            // 
            // btn_SuaLop
            // 
            this.btn_SuaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaLop.Location = new System.Drawing.Point(258, 489);
            this.btn_SuaLop.Name = "btn_SuaLop";
            this.btn_SuaLop.Size = new System.Drawing.Size(110, 42);
            this.btn_SuaLop.TabIndex = 24;
            this.btn_SuaLop.Text = "Sửa";
            this.btn_SuaLop.UseVisualStyleBackColor = true;
            this.btn_SuaLop.Click += new System.EventHandler(this.btn_SuaLop_Click);
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLop.Location = new System.Drawing.Point(69, 489);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(110, 42);
            this.btn_ThemLop.TabIndex = 23;
            this.btn_ThemLop.Text = "Thêm";
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.txt_TimKiemLop);
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(104, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 79);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thông tin HLV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(248, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiemLop
            // 
            this.txt_TimKiemLop.Location = new System.Drawing.Point(21, 36);
            this.txt_TimKiemLop.Name = "txt_TimKiemLop";
            this.txt_TimKiemLop.Size = new System.Drawing.Size(214, 23);
            this.txt_TimKiemLop.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1338, 83);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::GUI.Properties.Resources.next__1_;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(1234, 13);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(101, 70);
            this.pictureBox14.TabIndex = 21;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::GUI.Properties.Resources.next__1_;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(672, 13);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(101, 70);
            this.pictureBox13.TabIndex = 19;
            this.pictureBox13.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(845, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(345, 53);
            this.label27.TabIndex = 20;
            this.label27.Text = "Quản lý lớp học";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RosyBrown;
            this.panel7.Controls.Add(this.pictureBox12);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.txt_tongsolophoc);
            this.panel7.Location = new System.Drawing.Point(4, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 83);
            this.panel7.TabIndex = 12;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::GUI.Properties.Resources.webinar;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(3, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(74, 68);
            this.pictureBox12.TabIndex = 5;
            this.pictureBox12.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.RosyBrown;
            this.label26.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(97, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(166, 19);
            this.label26.TabIndex = 10;
            this.label26.Text = "Lớp học đã đăng ký";
            // 
            // txt_tongsolophoc
            // 
            this.txt_tongsolophoc.AutoSize = true;
            this.txt_tongsolophoc.BackColor = System.Drawing.Color.RosyBrown;
            this.txt_tongsolophoc.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsolophoc.ForeColor = System.Drawing.Color.White;
            this.txt_tongsolophoc.Location = new System.Drawing.Point(151, 3);
            this.txt_tongsolophoc.Name = "txt_tongsolophoc";
            this.txt_tongsolophoc.Size = new System.Drawing.Size(37, 42);
            this.txt_tongsolophoc.TabIndex = 11;
            this.txt_tongsolophoc.Text = "5";
            // 
            // dtgLopHoc
            // 
            this.dtgLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLopHoc.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDLop,
            this.col_TenLop,
            this.col_IDHLV_Lop,
            this.col_ThoiGianHoc});
            this.dtgLopHoc.Location = new System.Drawing.Point(668, 83);
            this.dtgLopHoc.Name = "dtgLopHoc";
            this.dtgLopHoc.RowHeadersWidth = 51;
            this.dtgLopHoc.RowTemplate.Height = 24;
            this.dtgLopHoc.Size = new System.Drawing.Size(666, 457);
            this.dtgLopHoc.TabIndex = 0;
            // 
            // col_IDLop
            // 
            this.col_IDLop.HeaderText = "ID Lớp";
            this.col_IDLop.MinimumWidth = 6;
            this.col_IDLop.Name = "col_IDLop";
            // 
            // col_TenLop
            // 
            this.col_TenLop.HeaderText = "Tên Lớp";
            this.col_TenLop.MinimumWidth = 6;
            this.col_TenLop.Name = "col_TenLop";
            // 
            // col_IDHLV_Lop
            // 
            this.col_IDHLV_Lop.HeaderText = "HLV";
            this.col_IDHLV_Lop.MinimumWidth = 6;
            this.col_IDHLV_Lop.Name = "col_IDHLV_Lop";
            // 
            // col_ThoiGianHoc
            // 
            this.col_ThoiGianHoc.HeaderText = "Thời gian học";
            this.col_ThoiGianHoc.MinimumWidth = 6;
            this.col_ThoiGianHoc.Name = "col_ThoiGianHoc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_TenHLV);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.txt_IDLop);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.txt_ThoiGianHoc);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.txt_TenLop);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(70, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 264);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin lớp học";
            // 
            // txt_TenHLV
            // 
            this.txt_TenHLV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_TenHLV.Enabled = false;
            this.txt_TenHLV.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHLV.Location = new System.Drawing.Point(159, 146);
            this.txt_TenHLV.Name = "txt_TenHLV";
            this.txt_TenHLV.Size = new System.Drawing.Size(227, 26);
            this.txt_TenHLV.TabIndex = 37;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label28.Location = new System.Drawing.Point(6, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 23);
            this.label28.TabIndex = 35;
            this.label28.Text = "Mã lớp:";
            // 
            // txt_IDLop
            // 
            this.txt_IDLop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_IDLop.Enabled = false;
            this.txt_IDLop.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDLop.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_IDLop.Location = new System.Drawing.Point(159, 47);
            this.txt_IDLop.Name = "txt_IDLop";
            this.txt_IDLop.Size = new System.Drawing.Size(192, 26);
            this.txt_IDLop.TabIndex = 26;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label30.Location = new System.Drawing.Point(2, 200);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(130, 23);
            this.label30.TabIndex = 23;
            this.label30.Text = "Thời gian học:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label30.UseWaitCursor = true;
            // 
            // txt_ThoiGianHoc
            // 
            this.txt_ThoiGianHoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_ThoiGianHoc.Enabled = false;
            this.txt_ThoiGianHoc.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGianHoc.Location = new System.Drawing.Point(160, 202);
            this.txt_ThoiGianHoc.Name = "txt_ThoiGianHoc";
            this.txt_ThoiGianHoc.Size = new System.Drawing.Size(306, 23);
            this.txt_ThoiGianHoc.TabIndex = 29;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label31.Location = new System.Drawing.Point(2, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 23);
            this.label31.TabIndex = 21;
            this.label31.Text = "Tên Lớp:";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_TenLop.Enabled = false;
            this.txt_TenLop.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLop.Location = new System.Drawing.Point(159, 91);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(270, 26);
            this.txt_TenLop.TabIndex = 27;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(7, 146);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(150, 23);
            this.label34.TabIndex = 22;
            this.label34.Text = "Huấn luyên viên:";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::GUI.Properties.Resources.next;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(54, 110);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(65, 40);
            this.pictureBox15.TabIndex = 22;
            this.pictureBox15.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage5.Controls.Add(this.panel11);
            this.tabPage5.Controls.Add(this.panel10);
            this.tabPage5.Controls.Add(this.panel9);
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Controls.Add(this.panel8);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.dtg_TT_HLV);
            this.tabPage5.Controls.Add(this.dtg_TT_HV);
            this.tabPage5.Controls.Add(this.pictureBox16);
            this.tabPage5.Controls.Add(this.pictureBox11);
            this.tabPage5.ImageIndex = 3;
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1334, 571);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Quản lý thông tin";
            this.tabPage5.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel11.Location = new System.Drawing.Point(0, 525);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1334, 32);
            this.panel11.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel10.Location = new System.Drawing.Point(1324, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 557);
            this.panel10.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 557);
            this.panel9.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Tan;
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.pictureBox8);
            this.panel6.Location = new System.Drawing.Point(551, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 74);
            this.panel6.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Tan;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(135, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 42);
            this.label21.TabIndex = 9;
            this.label21.Text = "5";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Tan;
            this.label22.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(97, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 19);
            this.label22.TabIndex = 8;
            this.label22.Text = "HLV đã đăng ký";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::GUI.Properties.Resources.coach;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(3, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(74, 68);
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Location = new System.Drawing.Point(42, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 74);
            this.panel2.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(158, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 42);
            this.label20.TabIndex = 7;
            this.label20.Text = "5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(93, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 19);
            this.label19.TabIndex = 6;
            this.label19.Text = "Học viên đã đăng ký";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::GUI.Properties.Resources.student;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(74, 68);
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Plum;
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Location = new System.Drawing.Point(938, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 74);
            this.panel4.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Plum;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(144, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 42);
            this.label23.TabIndex = 11;
            this.label23.Text = "5";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Plum;
            this.label24.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(91, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 19);
            this.label24.TabIndex = 10;
            this.label24.Text = "Lớp học đã đăng ký";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::GUI.Properties.Resources.webinar;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(3, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(74, 68);
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel8.Location = new System.Drawing.Point(3, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1336, 10);
            this.panel8.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1338, 10);
            this.panel5.TabIndex = 14;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(1100, 492);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 27);
            this.label33.TabIndex = 12;
            this.label33.Text = "100.000$ VND";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(886, 492);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(208, 27);
            this.label35.TabIndex = 11;
            this.label35.Text = "Tổng tiền lương HLV:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(336, 492);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(133, 27);
            this.label32.TabIndex = 9;
            this.label32.Text = "100.000$ VND";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(105, 492);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(212, 27);
            this.label29.TabIndex = 8;
            this.label29.Text = "Tổng tiền học phí HV:";
            // 
            // dtg_TT_HLV
            // 
            this.dtg_TT_HLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_TT_HLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_TT_HLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TT_IDHLV,
            this.col_TT_TenHLV,
            this.col_TT_LuongHLV});
            this.dtg_TT_HLV.Location = new System.Drawing.Point(791, 111);
            this.dtg_TT_HLV.Name = "dtg_TT_HLV";
            this.dtg_TT_HLV.RowHeadersWidth = 51;
            this.dtg_TT_HLV.RowTemplate.Height = 24;
            this.dtg_TT_HLV.Size = new System.Drawing.Size(518, 334);
            this.dtg_TT_HLV.TabIndex = 7;
            // 
            // col_TT_IDHLV
            // 
            this.col_TT_IDHLV.HeaderText = "ID HLV";
            this.col_TT_IDHLV.MinimumWidth = 6;
            this.col_TT_IDHLV.Name = "col_TT_IDHLV";
            // 
            // col_TT_TenHLV
            // 
            this.col_TT_TenHLV.HeaderText = "Tên HLV";
            this.col_TT_TenHLV.MinimumWidth = 6;
            this.col_TT_TenHLV.Name = "col_TT_TenHLV";
            // 
            // col_TT_LuongHLV
            // 
            this.col_TT_LuongHLV.HeaderText = "Lương HLV";
            this.col_TT_LuongHLV.MinimumWidth = 6;
            this.col_TT_LuongHLV.Name = "col_TT_LuongHLV";
            // 
            // dtg_TT_HV
            // 
            this.dtg_TT_HV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_TT_HV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_TT_HV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TT_IDHV,
            this.col_TT_TenHV,
            this.col_TT_HocPhiHV});
            this.dtg_TT_HV.Location = new System.Drawing.Point(25, 111);
            this.dtg_TT_HV.Name = "dtg_TT_HV";
            this.dtg_TT_HV.RowHeadersWidth = 51;
            this.dtg_TT_HV.RowTemplate.Height = 24;
            this.dtg_TT_HV.Size = new System.Drawing.Size(537, 334);
            this.dtg_TT_HV.TabIndex = 6;
            // 
            // col_TT_IDHV
            // 
            this.col_TT_IDHV.HeaderText = "ID Học viên";
            this.col_TT_IDHV.MinimumWidth = 6;
            this.col_TT_IDHV.Name = "col_TT_IDHV";
            // 
            // col_TT_TenHV
            // 
            this.col_TT_TenHV.HeaderText = "Tên Học Viên";
            this.col_TT_TenHV.MinimumWidth = 6;
            this.col_TT_TenHV.Name = "col_TT_TenHV";
            // 
            // col_TT_HocPhiHV
            // 
            this.col_TT_HocPhiHV.HeaderText = "Học phí ";
            this.col_TT_HocPhiHV.MinimumWidth = 6;
            this.col_TT_HocPhiHV.Name = "col_TT_HocPhiHV";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::GUI.Properties.Resources.right_down;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(791, 451);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(74, 68);
            this.pictureBox16.TabIndex = 13;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::GUI.Properties.Resources.right_down;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(25, 451);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(74, 68);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "student.png");
            this.imageList1.Images.SetKeyName(1, "child.png");
            this.imageList1.Images.SetKeyName(2, "coach (1).png");
            this.imageList1.Images.SetKeyName(3, "info.png");
            this.imageList1.Images.SetKeyName(4, "boxing.png");
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.White;
            this.pictureBox17.Location = new System.Drawing.Point(129, 20);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(263, 198);
            this.pictureBox17.TabIndex = 38;
            this.pictureBox17.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageIndex = 4;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1334, 571);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Sản phẩm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 751);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Quản lý phòng tập võ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_QLHOCVO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HLV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLopHoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TT_HLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TT_HV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_QLHOCVO;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ThemHV;
        private System.Windows.Forms.Button btn_SuaHV;
        private System.Windows.Forms.Button btn_XoaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IDHV;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.TextBox txt_TenHV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dtg_HLV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_XoaHLV;
        private System.Windows.Forms.Button btn_SuaHLV;
        private System.Windows.Forms.Button btn_ThemHLV;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ImageList imageList1;
        private DataGridViewTextBoxColumn col_IDHLV;
        private DataGridViewTextBoxColumn col_TenHLV;
        private DataGridViewTextBoxColumn col_GioiTinhHLV;
        private DataGridViewTextBoxColumn col_NgaySinhHLV;
        private DataGridViewTextBoxColumn col_SDTHLV;
        private DataGridViewTextBoxColumn col_ChuyenMon;
        private DataGridViewTextBoxColumn col_DiaChiHLV;
        private DataGridView dtgLopHoc;
        private TabPage tabPage5;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox8;
        private Panel panel6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Panel panel3;
        private Label txt_tongsolophoc;
        private Label label26;
        private PictureBox pictureBox12;
        private Panel panel7;
        private PictureBox pictureBox13;
        private Label label27;
        private PictureBox pictureBox14;
        private GroupBox groupBox4;
        private TextBox txt_TenHLV;
        private Label label28;
        private TextBox txt_IDLop;
        private Label label30;
        private TextBox txt_ThoiGianHoc;
        private Label label31;
        private TextBox txt_TenLop;
        private Label label34;
        private Button btn_XoaLop;
        private Button btn_SuaLop;
        private Button btn_ThemLop;
        private PictureBox pictureBox15;
        private GroupBox groupBox5;
        private Button button1;
        private Button button4;
        private TextBox txt_TimKiemLop;
        private DataGridView dtg_TT_HLV;
        private DataGridViewTextBoxColumn col_TT_IDHLV;
        private DataGridViewTextBoxColumn col_TT_TenHLV;
        private DataGridViewTextBoxColumn col_TT_LuongHLV;
        private DataGridView dtg_TT_HV;
        private DataGridViewTextBoxColumn col_TT_IDHV;
        private DataGridViewTextBoxColumn col_TT_TenHV;
        private DataGridViewTextBoxColumn col_TT_HocPhiHV;
        private Label label32;
        private Label label29;
        private PictureBox pictureBox11;
        private PictureBox pictureBox16;
        private Label label33;
        private Label label35;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Panel panel10;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn col_IDLop;
        private DataGridViewTextBoxColumn col_TenLop;
        private DataGridViewTextBoxColumn col_IDHLV_Lop;
        private DataGridViewTextBoxColumn col_ThoiGianHoc;
        private PictureBox pb_Refesh;
        private Label label25;
        private PictureBox pictureBox17;
        private TabPage tabPage4;
    }
}


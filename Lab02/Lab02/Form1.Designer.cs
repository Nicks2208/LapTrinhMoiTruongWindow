namespace Lab02
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
            this.txt_Number1 = new System.Windows.Forms.TextBox();
            this.txt_Number2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2:";
            // 
            // txt_Number1
            // 
            this.txt_Number1.Location = new System.Drawing.Point(183, 72);
            this.txt_Number1.Name = "txt_Number1";
            this.txt_Number1.Size = new System.Drawing.Size(123, 22);
            this.txt_Number1.TabIndex = 2;
            this.txt_Number1.TextChanged += new System.EventHandler(this.txt_Number1_TextChanged);
            this.txt_Number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number1_KeyPress);
            // 
            // txt_Number2
            // 
            this.txt_Number2.Location = new System.Drawing.Point(183, 130);
            this.txt_Number2.Name = "txt_Number2";
            this.txt_Number2.Size = new System.Drawing.Size(123, 22);
            this.txt_Number2.TabIndex = 3;
            this.txt_Number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CỘNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Location = new System.Drawing.Point(298, 253);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(75, 23);
            this.btn_Tru.TabIndex = 5;
            this.btn_Tru.Text = "TRỪ";
            this.btn_Tru.UseVisualStyleBackColor = true;
            this.btn_Tru.Click += new System.EventHandler(this.btn_Tru_Click);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Location = new System.Drawing.Point(474, 253);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhan.TabIndex = 6;
            this.btn_Nhan.Text = "NHÂN";
            this.btn_Nhan.UseVisualStyleBackColor = true;
            this.btn_Nhan.Click += new System.EventHandler(this.btn_Nhan_Click);
            // 
            // btn_Chia
            // 
            this.btn_Chia.Location = new System.Drawing.Point(648, 253);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(75, 23);
            this.btn_Chia.TabIndex = 7;
            this.btn_Chia.Text = "CHIA";
            this.btn_Chia.UseVisualStyleBackColor = true;
            this.btn_Chia.Click += new System.EventHandler(this.btn_Chia_Click);
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(183, 338);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(234, 22);
            this.txt_Answer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.btn_Chia);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Number2);
            this.Controls.Add(this.txt_Number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Number1;
        private System.Windows.Forms.TextBox txt_Number2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Tru;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_Chia;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider err;
    }
}


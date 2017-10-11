namespace B4
{
    partial class FormNhap
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_nhập = new System.Windows.Forms.Button();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mahang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 103);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(58, 21);
            this.comboBox3.TabIndex = 48;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(261, 147);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 46;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_nhập
            // 
            this.bt_nhập.Location = new System.Drawing.Point(60, 147);
            this.bt_nhập.Name = "bt_nhập";
            this.bt_nhập.Size = new System.Drawing.Size(75, 23);
            this.bt_nhập.TabIndex = 45;
            this.bt_nhập.Text = "Nhập";
            this.bt_nhập.UseVisualStyleBackColor = true;
            this.bt_nhập.Click += new System.EventHandler(this.bt_nhập_Click);
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(278, 107);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(58, 20);
            this.tb_soluong.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số lượng";
            // 
            // tb_mahang
            // 
            this.tb_mahang.Location = new System.Drawing.Point(278, 62);
            this.tb_mahang.Name = "tb_mahang";
            this.tb_mahang.Size = new System.Drawing.Size(58, 20);
            this.tb_mahang.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mã_hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã_Kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã_PN";
            // 
            // FormNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 226);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_nhập);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_mahang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormNhap";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.FormNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_nhập;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mahang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
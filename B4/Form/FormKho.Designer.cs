namespace B4
{
    partial class FormKho
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
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tenkho = new System.Windows.Forms.TextBox();
            this.tb_makho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(209, 124);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(48, 23);
            this.btthoat.TabIndex = 17;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(155, 124);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(48, 23);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(101, 124);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(48, 23);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(43, 124);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(48, 23);
            this.btthem.TabIndex = 14;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Kho";
            // 
            // tb_tenkho
            // 
            this.tb_tenkho.Location = new System.Drawing.Point(101, 81);
            this.tb_tenkho.Name = "tb_tenkho";
            this.tb_tenkho.Size = new System.Drawing.Size(149, 20);
            this.tb_tenkho.TabIndex = 11;
            // 
            // tb_makho
            // 
            this.tb_makho.Location = new System.Drawing.Point(101, 34);
            this.tb_makho.Name = "tb_makho";
            this.tb_makho.Size = new System.Drawing.Size(149, 20);
            this.tb_makho.TabIndex = 10;
            this.tb_makho.TextChanged += new System.EventHandler(this.tb_makho_TextChanged);
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 180);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tenkho);
            this.Controls.Add(this.tb_makho);
            this.Name = "FormKho";
            this.Text = "Kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tenkho;
        private System.Windows.Forms.TextBox tb_makho;
    }
}
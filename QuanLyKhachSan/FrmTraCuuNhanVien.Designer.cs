namespace QuanLyKhachSan
{
    partial class FrmTraCuuNhanVien
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbTenNV = new System.Windows.Forms.RadioButton();
            this.rbCMND = new System.Windows.Forms.RadioButton();
            this.rbMaNV = new System.Windows.Forms.RadioButton();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(341, 196);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(131, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // rbTenNV
            // 
            this.rbTenNV.AutoSize = true;
            this.rbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.rbTenNV.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTenNV.ForeColor = System.Drawing.Color.Green;
            this.rbTenNV.Location = new System.Drawing.Point(408, 112);
            this.rbTenNV.Name = "rbTenNV";
            this.rbTenNV.Size = new System.Drawing.Size(123, 25);
            this.rbTenNV.TabIndex = 2;
            this.rbTenNV.TabStop = true;
            this.rbTenNV.Text = "Theo Tên NV";
            this.rbTenNV.UseVisualStyleBackColor = false;
            // 
            // rbCMND
            // 
            this.rbCMND.AutoSize = true;
            this.rbCMND.BackColor = System.Drawing.Color.Transparent;
            this.rbCMND.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCMND.ForeColor = System.Drawing.Color.Green;
            this.rbCMND.Location = new System.Drawing.Point(232, 112);
            this.rbCMND.Name = "rbCMND";
            this.rbCMND.Size = new System.Drawing.Size(117, 25);
            this.rbCMND.TabIndex = 1;
            this.rbCMND.TabStop = true;
            this.rbCMND.Text = "Theo CMND";
            this.rbCMND.UseVisualStyleBackColor = false;
            // 
            // rbMaNV
            // 
            this.rbMaNV.AutoSize = true;
            this.rbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.rbMaNV.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaNV.ForeColor = System.Drawing.Color.Green;
            this.rbMaNV.Location = new System.Drawing.Point(55, 112);
            this.rbMaNV.Name = "rbMaNV";
            this.rbMaNV.Size = new System.Drawing.Size(119, 25);
            this.rbMaNV.TabIndex = 0;
            this.rbMaNV.TabStop = true;
            this.rbMaNV.Text = "Theo Mã NV";
            this.rbMaNV.UseVisualStyleBackColor = false;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(37, 310);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(899, 100);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmTraCuuNV;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.rbMaNV);
            this.panel1.Controls.Add(this.rbTenNV);
            this.panel1.Controls.Add(this.rbCMND);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 440);
            this.panel1.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.btnSearch;
            this.btnTimKiem.Location = new System.Drawing.Point(478, 187);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 37);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmTraCuuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 441);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTraCuuNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTraCuuNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbMaNV;
        private System.Windows.Forms.RadioButton rbTenNV;
        private System.Windows.Forms.RadioButton rbCMND;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnTimKiem;
    }
}
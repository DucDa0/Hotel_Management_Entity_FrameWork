namespace QuanLyKhachSan
{
    partial class FrmTraCuuKhachHang
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
            this.rbMaKH = new System.Windows.Forms.RadioButton();
            this.cBOff = new System.Windows.Forms.CheckBox();
            this.cBOnl = new System.Windows.Forms.CheckBox();
            this.rbSDT = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbCMND = new System.Windows.Forms.RadioButton();
            this.rbTenKH = new System.Windows.Forms.RadioButton();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMaKH
            // 
            this.rbMaKH.AutoSize = true;
            this.rbMaKH.BackColor = System.Drawing.Color.Transparent;
            this.rbMaKH.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaKH.ForeColor = System.Drawing.Color.Green;
            this.rbMaKH.Location = new System.Drawing.Point(56, 111);
            this.rbMaKH.Name = "rbMaKH";
            this.rbMaKH.Size = new System.Drawing.Size(119, 25);
            this.rbMaKH.TabIndex = 0;
            this.rbMaKH.TabStop = true;
            this.rbMaKH.Text = "Theo Mã KH";
            this.rbMaKH.UseVisualStyleBackColor = false;
            // 
            // cBOff
            // 
            this.cBOff.AutoSize = true;
            this.cBOff.BackColor = System.Drawing.Color.Transparent;
            this.cBOff.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBOff.ForeColor = System.Drawing.Color.Green;
            this.cBOff.Location = new System.Drawing.Point(207, 202);
            this.cBOff.Name = "cBOff";
            this.cBOff.Size = new System.Drawing.Size(126, 25);
            this.cBOff.TabIndex = 7;
            this.cBOff.Text = "Không còn ở";
            this.cBOff.UseVisualStyleBackColor = false;
            // 
            // cBOnl
            // 
            this.cBOnl.AutoSize = true;
            this.cBOnl.BackColor = System.Drawing.Color.Transparent;
            this.cBOnl.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBOnl.ForeColor = System.Drawing.Color.Green;
            this.cBOnl.Location = new System.Drawing.Point(56, 202);
            this.cBOnl.Name = "cBOnl";
            this.cBOnl.Size = new System.Drawing.Size(73, 25);
            this.cBOnl.TabIndex = 6;
            this.cBOnl.Text = "Còn ở";
            this.cBOnl.UseVisualStyleBackColor = false;
            // 
            // rbSDT
            // 
            this.rbSDT.AutoSize = true;
            this.rbSDT.BackColor = System.Drawing.Color.Transparent;
            this.rbSDT.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSDT.ForeColor = System.Drawing.Color.Green;
            this.rbSDT.Location = new System.Drawing.Point(510, 111);
            this.rbSDT.Name = "rbSDT";
            this.rbSDT.Size = new System.Drawing.Size(100, 25);
            this.rbSDT.TabIndex = 5;
            this.rbSDT.TabStop = true;
            this.rbSDT.Text = "Theo SĐT";
            this.rbSDT.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(344, 246);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // rbCMND
            // 
            this.rbCMND.AutoSize = true;
            this.rbCMND.BackColor = System.Drawing.Color.Transparent;
            this.rbCMND.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCMND.ForeColor = System.Drawing.Color.Green;
            this.rbCMND.Location = new System.Drawing.Point(358, 111);
            this.rbCMND.Name = "rbCMND";
            this.rbCMND.Size = new System.Drawing.Size(117, 25);
            this.rbCMND.TabIndex = 2;
            this.rbCMND.TabStop = true;
            this.rbCMND.Text = "Theo CMND";
            this.rbCMND.UseVisualStyleBackColor = false;
            // 
            // rbTenKH
            // 
            this.rbTenKH.AutoSize = true;
            this.rbTenKH.BackColor = System.Drawing.Color.Transparent;
            this.rbTenKH.Font = new System.Drawing.Font("Montserrat Semi Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTenKH.ForeColor = System.Drawing.Color.Green;
            this.rbTenKH.Location = new System.Drawing.Point(207, 111);
            this.rbTenKH.Name = "rbTenKH";
            this.rbTenKH.Size = new System.Drawing.Size(123, 25);
            this.rbTenKH.TabIndex = 1;
            this.rbTenKH.TabStop = true;
            this.rbTenKH.Text = "Theo Tên KH";
            this.rbTenKH.UseVisualStyleBackColor = false;
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(25, 304);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(917, 109);
            this.dgvHienThi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmTraCuuKH;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cBOff);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.cBOnl);
            this.panel1.Controls.Add(this.rbMaKH);
            this.panel1.Controls.Add(this.rbSDT);
            this.panel1.Controls.Add(this.rbTenKH);
            this.panel1.Controls.Add(this.rbCMND);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 440);
            this.panel1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.btnSearch;
            this.btnTimKiem.Location = new System.Drawing.Point(510, 236);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 37);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmTraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 439);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTraCuuKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTraCuuKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaKH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rbCMND;
        private System.Windows.Forms.RadioButton rbTenKH;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.RadioButton rbSDT;
        private System.Windows.Forms.CheckBox cBOff;
        private System.Windows.Forms.CheckBox cBOnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnTimKiem;
    }
}
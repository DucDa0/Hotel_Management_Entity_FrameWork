namespace QuanLyKhachSan
{
    partial class QLKhachHang
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
            this.panel0 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.PictureBox();
            this.btnLuu = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbxQuocTich = new System.Windows.Forms.ComboBox();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel0
            // 
            this.panel0.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmQLHK2;
            this.panel0.Controls.Add(this.dgvKhachHang);
            this.panel0.Controls.Add(this.btnTimKiem);
            this.panel0.Controls.Add(this.btnHuy);
            this.panel0.Controls.Add(this.btnSua);
            this.panel0.Controls.Add(this.btnThem);
            this.panel0.Controls.Add(this.btnXoa);
            this.panel0.Controls.Add(this.btnLuu);
            this.panel0.Controls.Add(this.btnReload);
            this.panel0.Controls.Add(this.txtTimKiem);
            this.panel0.Controls.Add(this.panel1);
            this.panel0.Location = new System.Drawing.Point(1, 1);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(894, 656);
            this.panel0.TabIndex = 11;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(27, 324);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(836, 298);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.btnSearch;
            this.btnTimKiem.Location = new System.Drawing.Point(219, 265);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 37);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.Image = global::QuanLyKhachSan.Properties.Resources.btnCancel;
            this.btnHuy.Location = new System.Drawing.Point(219, 187);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 37);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.TabStop = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Image = global::QuanLyKhachSan.Properties.Resources.btnEdit;
            this.btnSua.Location = new System.Drawing.Point(219, 131);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 37);
            this.btnSua.TabIndex = 20;
            this.btnSua.TabStop = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = global::QuanLyKhachSan.Properties.Resources.btnAdd;
            this.btnThem.Location = new System.Drawing.Point(219, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 37);
            this.btnThem.TabIndex = 19;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Image = global::QuanLyKhachSan.Properties.Resources.btnDelete;
            this.btnXoa.Location = new System.Drawing.Point(77, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 37);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.TabStop = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Image = global::QuanLyKhachSan.Properties.Resources.btnSave;
            this.btnLuu.Location = new System.Drawing.Point(77, 131);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 37);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.TabStop = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = global::QuanLyKhachSan.Properties.Resources.btnReload;
            this.btnReload.Location = new System.Drawing.Point(77, 76);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(103, 37);
            this.btnReload.TabIndex = 16;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(69, 275);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(136, 20);
            this.txtTimKiem.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.cbxGioiTinh);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.cbxQuocTich);
            this.panel1.Location = new System.Drawing.Point(377, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 248);
            this.panel1.TabIndex = 23;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(291, 150);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(136, 20);
            this.txtSDT.TabIndex = 11;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(24, 38);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(109, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(291, 93);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(136, 20);
            this.txtCMND.TabIndex = 9;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(24, 93);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(225, 20);
            this.txtTenKH.TabIndex = 3;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.BackColor = System.Drawing.Color.Bisque;
            this.cbxGioiTinh.DropDownWidth = 55;
            this.cbxGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(291, 38);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(55, 21);
            this.cbxGioiTinh.TabIndex = 14;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(24, 150);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(128, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // cbxQuocTich
            // 
            this.cbxQuocTich.BackColor = System.Drawing.Color.Bisque;
            this.cbxQuocTich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxQuocTich.FormattingEnabled = true;
            this.cbxQuocTich.Items.AddRange(new object[] {
            "Anh",
            "Ai Cập",
            "Ấn Độ",
            "Áo",
            "Argentina",
            "Ba Lan",
            "Bồ Đào Nha",
            "Brazil",
            "Bỉ",
            "Campuchia",
            "Colombia",
            "Chile",
            "Croatia",
            "Đài Loan",
            "Đan Mạch",
            "Đức",
            "Nhật Bản",
            "Hàn Quốc",
            "Trung Quốc",
            "Uzbekitan",
            "Việt Nam"});
            this.cbxQuocTich.Location = new System.Drawing.Point(24, 204);
            this.cbxQuocTich.Name = "cbxQuocTich";
            this.cbxQuocTich.Size = new System.Drawing.Size(121, 21);
            this.cbxQuocTich.TabIndex = 15;
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 648);
            this.Controls.Add(this.panel0);
            this.Name = "QLKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKhachHang";
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.ComboBox cbxQuocTich;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.PictureBox btnLuu;
        private System.Windows.Forms.PictureBox btnXoa;
        private System.Windows.Forms.PictureBox btnSua;
        private System.Windows.Forms.PictureBox btnThem;
        private System.Windows.Forms.PictureBox btnHuy;
        private System.Windows.Forms.PictureBox btnTimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}
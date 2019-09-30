namespace QuanLyKhachSan
{
    partial class QLPhongThue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.cbxMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaDK = new System.Windows.Forms.TextBox();
            this.cbxTenPhong = new System.Windows.Forms.ComboBox();
            this.dgvPhongThue = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.PictureBox();
            this.btnLuu = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongThue)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbxTinhTrang);
            this.panel1.Controls.Add(this.dtpNgayDK);
            this.panel1.Controls.Add(this.cbxMaKH);
            this.panel1.Controls.Add(this.txtMaDK);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(378, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 249);
            this.panel1.TabIndex = 0;
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.BackColor = System.Drawing.Color.DarkSalmon;
            this.cbxTinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "Onl",
            "Off"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(257, 110);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(47, 21);
            this.cbxTinhTrang.TabIndex = 9;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDK.Location = new System.Drawing.Point(257, 49);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(115, 20);
            this.dtpNgayDK.TabIndex = 7;
            // 
            // cbxMaKH
            // 
            this.cbxMaKH.BackColor = System.Drawing.Color.DarkSalmon;
            this.cbxMaKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxMaKH.FormattingEnabled = true;
            this.cbxMaKH.Location = new System.Drawing.Point(24, 110);
            this.cbxMaKH.Name = "cbxMaKH";
            this.cbxMaKH.Size = new System.Drawing.Size(100, 21);
            this.cbxMaKH.TabIndex = 3;
            // 
            // txtMaDK
            // 
            this.txtMaDK.Location = new System.Drawing.Point(22, 49);
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(100, 20);
            this.txtMaDK.TabIndex = 1;
            // 
            // cbxTenPhong
            // 
            this.cbxTenPhong.BackColor = System.Drawing.Color.DarkSalmon;
            this.cbxTenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTenPhong.FormattingEnabled = true;
            this.cbxTenPhong.Location = new System.Drawing.Point(402, 237);
            this.cbxTenPhong.Name = "cbxTenPhong";
            this.cbxTenPhong.Size = new System.Drawing.Size(100, 21);
            this.cbxTenPhong.TabIndex = 5;
            // 
            // dgvPhongThue
            // 
            this.dgvPhongThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongThue.Location = new System.Drawing.Point(33, 331);
            this.dgvPhongThue.Name = "dgvPhongThue";
            this.dgvPhongThue.Size = new System.Drawing.Size(829, 294);
            this.dgvPhongThue.TabIndex = 1;
            this.dgvPhongThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongThue_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(69, 274);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(129, 20);
            this.txtTimKiem.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmQLPT;
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.dgvPhongThue);
            this.panel2.Controls.Add(this.cbxTenPhong);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 656);
            this.panel2.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.btnSearch;
            this.btnTimKiem.Location = new System.Drawing.Point(216, 265);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 37);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.Image = global::QuanLyKhachSan.Properties.Resources.btnCancel;
            this.btnHuy.Location = new System.Drawing.Point(216, 196);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 37);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.TabStop = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Image = global::QuanLyKhachSan.Properties.Resources.btnEdit;
            this.btnSua.Location = new System.Drawing.Point(216, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 37);
            this.btnSua.TabIndex = 27;
            this.btnSua.TabStop = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = global::QuanLyKhachSan.Properties.Resources.btnAdd;
            this.btnThem.Location = new System.Drawing.Point(216, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 37);
            this.btnThem.TabIndex = 26;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Image = global::QuanLyKhachSan.Properties.Resources.btnDelete;
            this.btnXoa.Location = new System.Drawing.Point(69, 196);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 37);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.TabStop = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Image = global::QuanLyKhachSan.Properties.Resources.btnSave;
            this.btnLuu.Location = new System.Drawing.Point(69, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 37);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.TabStop = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = global::QuanLyKhachSan.Properties.Resources.btnReload;
            this.btnReload.Location = new System.Drawing.Point(69, 87);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(103, 37);
            this.btnReload.TabIndex = 23;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // QLPhongThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 651);
            this.Controls.Add(this.panel2);
            this.Name = "QLPhongThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLPhongThue";
            this.Load += new System.EventHandler(this.QLPHONGTHUE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongThue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhongThue;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.ComboBox cbxTenPhong;
        private System.Windows.Forms.ComboBox cbxMaKH;
        private System.Windows.Forms.TextBox txtMaDK;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.PictureBox btnLuu;
        private System.Windows.Forms.PictureBox btnXoa;
        private System.Windows.Forms.PictureBox btnThem;
        private System.Windows.Forms.PictureBox btnSua;
        private System.Windows.Forms.PictureBox btnHuy;
        private System.Windows.Forms.PictureBox btnTimKiem;
    }
}
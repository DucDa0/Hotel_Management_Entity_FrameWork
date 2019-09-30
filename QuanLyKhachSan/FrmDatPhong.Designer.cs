namespace QuanLyKhachSan
{
    partial class FrmDatPhong
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
            this.rBTheoGT = new System.Windows.Forms.RadioButton();
            this.txtTien1 = new System.Windows.Forms.TextBox();
            this.txtTien2 = new System.Windows.Forms.TextBox();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.btnLoc = new System.Windows.Forms.PictureBox();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            this.rBTheoLP = new System.Windows.Forms.RadioButton();
            this.btnThemKH = new System.Windows.Forms.PictureBox();
            this.btnDatPhong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // rBTheoGT
            // 
            this.rBTheoGT.AutoSize = true;
            this.rBTheoGT.BackColor = System.Drawing.Color.Transparent;
            this.rBTheoGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTheoGT.ForeColor = System.Drawing.Color.Green;
            this.rBTheoGT.Location = new System.Drawing.Point(54, 252);
            this.rBTheoGT.Name = "rBTheoGT";
            this.rBTheoGT.Size = new System.Drawing.Size(90, 24);
            this.rBTheoGT.TabIndex = 3;
            this.rBTheoGT.TabStop = true;
            this.rBTheoGT.Text = "Giá tiền";
            this.rBTheoGT.UseVisualStyleBackColor = false;
            // 
            // txtTien1
            // 
            this.txtTien1.Location = new System.Drawing.Point(237, 254);
            this.txtTien1.Name = "txtTien1";
            this.txtTien1.Size = new System.Drawing.Size(100, 20);
            this.txtTien1.TabIndex = 5;
            // 
            // txtTien2
            // 
            this.txtTien2.Location = new System.Drawing.Point(372, 254);
            this.txtTien2.Name = "txtTien2";
            this.txtTien2.Size = new System.Drawing.Size(100, 20);
            this.txtTien2.TabIndex = 6;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(47, 405);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.Size = new System.Drawing.Size(437, 207);
            this.dgvLoaiPhong.TabIndex = 7;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(237, 218);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(135, 21);
            this.cbxLoaiPhong.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmDatPhong2;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.rBTheoLP);
            this.panel1.Controls.Add(this.dgvLoaiPhong);
            this.panel1.Controls.Add(this.cbxLoaiPhong);
            this.panel1.Controls.Add(this.btnThemKH);
            this.panel1.Controls.Add(this.txtTien2);
            this.panel1.Controls.Add(this.rBTheoGT);
            this.panel1.Controls.Add(this.txtTien1);
            this.panel1.Controls.Add(this.btnDatPhong);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 656);
            this.panel1.TabIndex = 11;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = global::QuanLyKhachSan.Properties.Resources.btnReset;
            this.btnReload.Location = new System.Drawing.Point(455, 372);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 27);
            this.btnReload.TabIndex = 16;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Transparent;
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.Image = global::QuanLyKhachSan.Properties.Resources.btnLoc;
            this.btnLoc.Location = new System.Drawing.Point(258, 300);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(107, 37);
            this.btnLoc.TabIndex = 15;
            this.btnLoc.TabStop = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.btnTim;
            this.btnTimKiem.Location = new System.Drawing.Point(144, 300);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 37);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rBTheoLP
            // 
            this.rBTheoLP.AutoSize = true;
            this.rBTheoLP.BackColor = System.Drawing.Color.Transparent;
            this.rBTheoLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTheoLP.ForeColor = System.Drawing.Color.Green;
            this.rBTheoLP.Location = new System.Drawing.Point(54, 217);
            this.rBTheoLP.Name = "rBTheoLP";
            this.rBTheoLP.Size = new System.Drawing.Size(117, 24);
            this.rBTheoLP.TabIndex = 13;
            this.rBTheoLP.TabStop = true;
            this.rBTheoLP.Text = "Loại Phòng";
            this.rBTheoLP.UseVisualStyleBackColor = false;
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.Transparent;
            this.btnThemKH.Image = global::QuanLyKhachSan.Properties.Resources.btnThemKH;
            this.btnThemKH.Location = new System.Drawing.Point(193, 78);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(128, 37);
            this.btnThemKH.TabIndex = 12;
            this.btnThemKH.TabStop = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.Image = global::QuanLyKhachSan.Properties.Resources.btnDatPhong;
            this.btnDatPhong.Location = new System.Drawing.Point(47, 78);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(128, 37);
            this.btnDatPhong.TabIndex = 11;
            this.btnDatPhong.TabStop = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmDatPhong;
            this.ClientSize = new System.Drawing.Size(522, 657);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatPhong";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDatPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rBTheoGT;
        private System.Windows.Forms.TextBox txtTien1;
        private System.Windows.Forms.TextBox txtTien2;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnDatPhong;
        private System.Windows.Forms.PictureBox btnThemKH;
        private System.Windows.Forms.RadioButton rBTheoLP;
        private System.Windows.Forms.PictureBox btnTimKiem;
        private System.Windows.Forms.PictureBox btnLoc;
        private System.Windows.Forms.PictureBox btnReload;
    }
}
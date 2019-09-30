namespace QuanLyKhachSan
{
    partial class FrmThongKe
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNgayLapHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTienHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNgayTK = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtSLDV = new System.Windows.Forms.TextBox();
            this.txtSLKH = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmThongKe;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.dtpNgayTK);
            this.panel3.Controls.Add(this.btnThongKe);
            this.panel3.Controls.Add(this.txtDoanhThu);
            this.panel3.Controls.Add(this.btnLoc);
            this.panel3.Controls.Add(this.txtSLDV);
            this.panel3.Controls.Add(this.txtSLKH);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 536);
            this.panel3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMaKH,
            this.clmNgayLapHD,
            this.clmTienHD});
            this.listView1.Location = new System.Drawing.Point(21, 330);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 194);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clmMaKH
            // 
            this.clmMaKH.Text = "Mã KH";
            // 
            // clmNgayLapHD
            // 
            this.clmNgayLapHD.Text = "Ngày Lập HĐ";
            this.clmNgayLapHD.Width = 100;
            // 
            // clmTienHD
            // 
            this.clmTienHD.Text = "Tổng Tiền Hóa Đơn";
            this.clmTienHD.Width = 300;
            // 
            // dtpNgayTK
            // 
            this.dtpNgayTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTK.Location = new System.Drawing.Point(35, 255);
            this.dtpNgayTK.Name = "dtpNgayTK";
            this.dtpNgayTK.Size = new System.Drawing.Size(115, 20);
            this.dtpNgayTK.TabIndex = 8;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.btnThongKe;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKe.Location = new System.Drawing.Point(432, 70);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(125, 39);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(454, 251);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(115, 20);
            this.txtDoanhThu.TabIndex = 6;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Transparent;
            this.btnLoc.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.btnLoc;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc.Location = new System.Drawing.Point(318, 71);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(107, 37);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtSLDV
            // 
            this.txtSLDV.Location = new System.Drawing.Point(221, 304);
            this.txtSLDV.Name = "txtSLDV";
            this.txtSLDV.ReadOnly = true;
            this.txtSLDV.Size = new System.Drawing.Size(81, 20);
            this.txtSLDV.TabIndex = 5;
            // 
            // txtSLKH
            // 
            this.txtSLKH.Location = new System.Drawing.Point(221, 251);
            this.txtSLKH.Name = "txtSLKH";
            this.txtSLKH.ReadOnly = true;
            this.txtSLKH.Size = new System.Drawing.Size(81, 20);
            this.txtSLKH.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 537);
            this.Controls.Add(this.panel3);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpNgayTK;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.TextBox txtSLDV;
        private System.Windows.Forms.TextBox txtSLKH;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ColumnHeader clmMaKH;
        private System.Windows.Forms.ColumnHeader clmNgayLapHD;
        private System.Windows.Forms.ColumnHeader clmTienHD;
        private System.Windows.Forms.Panel panel3;
    }
}
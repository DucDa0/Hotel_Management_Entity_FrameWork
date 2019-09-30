namespace QuanLyKhachSan
{
    partial class FrmDatDichVu
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
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.cbxMaDV = new System.Windows.Forms.ComboBox();
            this.cbxTenDV = new System.Windows.Forms.ComboBox();
            this.txtGiaDV2 = new System.Windows.Forms.TextBox();
            this.txtGiaDV1 = new System.Windows.Forms.TextBox();
            this.rBGiaDV = new System.Windows.Forms.RadioButton();
            this.rBTenDV = new System.Windows.Forms.RadioButton();
            this.rBMaDV = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(53, 385);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(424, 225);
            this.dgvDichVu.TabIndex = 10;
            // 
            // cbxMaDV
            // 
            this.cbxMaDV.FormattingEnabled = true;
            this.cbxMaDV.Location = new System.Drawing.Point(238, 173);
            this.cbxMaDV.Name = "cbxMaDV";
            this.cbxMaDV.Size = new System.Drawing.Size(77, 21);
            this.cbxMaDV.TabIndex = 8;
            // 
            // cbxTenDV
            // 
            this.cbxTenDV.FormattingEnabled = true;
            this.cbxTenDV.Location = new System.Drawing.Point(238, 244);
            this.cbxTenDV.Name = "cbxTenDV";
            this.cbxTenDV.Size = new System.Drawing.Size(206, 21);
            this.cbxTenDV.TabIndex = 7;
            // 
            // txtGiaDV2
            // 
            this.txtGiaDV2.Location = new System.Drawing.Point(377, 207);
            this.txtGiaDV2.Name = "txtGiaDV2";
            this.txtGiaDV2.Size = new System.Drawing.Size(100, 20);
            this.txtGiaDV2.TabIndex = 6;
            // 
            // txtGiaDV1
            // 
            this.txtGiaDV1.Location = new System.Drawing.Point(238, 207);
            this.txtGiaDV1.Name = "txtGiaDV1";
            this.txtGiaDV1.Size = new System.Drawing.Size(100, 20);
            this.txtGiaDV1.TabIndex = 5;
            // 
            // rBGiaDV
            // 
            this.rBGiaDV.AutoSize = true;
            this.rBGiaDV.BackColor = System.Drawing.Color.Transparent;
            this.rBGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBGiaDV.ForeColor = System.Drawing.Color.Green;
            this.rBGiaDV.Location = new System.Drawing.Point(55, 204);
            this.rBGiaDV.Name = "rBGiaDV";
            this.rBGiaDV.Size = new System.Drawing.Size(130, 24);
            this.rBGiaDV.TabIndex = 2;
            this.rBGiaDV.TabStop = true;
            this.rBGiaDV.Text = "Theo Giá DV";
            this.rBGiaDV.UseVisualStyleBackColor = false;
            // 
            // rBTenDV
            // 
            this.rBTenDV.AutoSize = true;
            this.rBTenDV.BackColor = System.Drawing.Color.Transparent;
            this.rBTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTenDV.ForeColor = System.Drawing.Color.Green;
            this.rBTenDV.Location = new System.Drawing.Point(55, 240);
            this.rBTenDV.Name = "rBTenDV";
            this.rBTenDV.Size = new System.Drawing.Size(132, 24);
            this.rBTenDV.TabIndex = 1;
            this.rBTenDV.TabStop = true;
            this.rBTenDV.Text = "Theo Tên DV";
            this.rBTenDV.UseVisualStyleBackColor = false;
            // 
            // rBMaDV
            // 
            this.rBMaDV.AutoSize = true;
            this.rBMaDV.BackColor = System.Drawing.Color.Transparent;
            this.rBMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBMaDV.ForeColor = System.Drawing.Color.Green;
            this.rBMaDV.Location = new System.Drawing.Point(54, 170);
            this.rBMaDV.Name = "rBMaDV";
            this.rBMaDV.Size = new System.Drawing.Size(126, 24);
            this.rBMaDV.TabIndex = 0;
            this.rBMaDV.TabStop = true;
            this.rBMaDV.Text = "Theo Mã DV";
            this.rBMaDV.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.FrmDatDichVu;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.dgvDichVu);
            this.panel1.Controls.Add(this.rBMaDV);
            this.panel1.Controls.Add(this.rBTenDV);
            this.panel1.Controls.Add(this.cbxTenDV);
            this.panel1.Controls.Add(this.cbxMaDV);
            this.panel1.Controls.Add(this.txtGiaDV2);
            this.panel1.Controls.Add(this.rBGiaDV);
            this.panel1.Controls.Add(this.txtGiaDV1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 656);
            this.panel1.TabIndex = 3;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = global::QuanLyKhachSan.Properties.Resources.btnReset;
            this.btnReload.Location = new System.Drawing.Point(166, 338);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 27);
            this.btnReload.TabIndex = 17;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.btnTim;
            this.btnTimKiem.Location = new System.Drawing.Point(53, 333);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 37);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmDatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 654);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDatDichVu";
            this.Text = "FrmDatDichVu";
            this.Load += new System.EventHandler(this.FrmDatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxMaDV;
        private System.Windows.Forms.ComboBox cbxTenDV;
        private System.Windows.Forms.TextBox txtGiaDV2;
        private System.Windows.Forms.TextBox txtGiaDV1;
        private System.Windows.Forms.RadioButton rBGiaDV;
        private System.Windows.Forms.RadioButton rBTenDV;
        private System.Windows.Forms.RadioButton rBMaDV;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnTimKiem;
        private System.Windows.Forms.PictureBox btnReload;
    }
}
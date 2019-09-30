namespace QuanLyKhachSan
{
    partial class FrmDangKi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxPQuyen = new System.Windows.Forms.ComboBox();
            this.txtRepass1 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Sign_Up1;
            this.panel2.Controls.Add(this.cbxPQuyen);
            this.panel2.Controls.Add(this.txtRepass1);
            this.panel2.Controls.Add(this.txtPass1);
            this.panel2.Controls.Add(this.txtUser1);
            this.panel2.Controls.Add(this.btnDangKy);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 386);
            this.panel2.TabIndex = 0;
            // 
            // cbxPQuyen
            // 
            this.cbxPQuyen.FormattingEnabled = true;
            this.cbxPQuyen.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxPQuyen.Location = new System.Drawing.Point(26, 284);
            this.cbxPQuyen.Name = "cbxPQuyen";
            this.cbxPQuyen.Size = new System.Drawing.Size(121, 21);
            this.cbxPQuyen.TabIndex = 4;
            // 
            // txtRepass1
            // 
            this.txtRepass1.Location = new System.Drawing.Point(26, 224);
            this.txtRepass1.Name = "txtRepass1";
            this.txtRepass1.Size = new System.Drawing.Size(222, 20);
            this.txtRepass1.TabIndex = 3;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(26, 172);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(222, 20);
            this.txtPass1.TabIndex = 2;
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(26, 116);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(222, 20);
            this.txtUser1.TabIndex = 1;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Image = global::QuanLyKhachSan.Properties.Resources.ButtonSignUp;
            this.btnDangKy.Location = new System.Drawing.Point(40, 327);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(208, 37);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.TabStop = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // FrmDangKi
            // 
            this.ClientSize = new System.Drawing.Size(280, 385);
            this.Controls.Add(this.panel2);
            this.Name = "FrmDangKi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.TextBox txtPass;
        //private System.Windows.Forms.TextBox txtUser;
        //private System.Windows.Forms.ComboBox cbxPhanQuyen;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.TextBox txtRepass;
        //private System.Windows.Forms.PictureBox btnDangKi;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRepass1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.PictureBox btnDangKy;
        private System.Windows.Forms.ComboBox cbxPQuyen;
    }
}
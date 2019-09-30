using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BS_Layer;
using System.Data.SqlClient;
namespace QuanLyKhachSan
{
    public partial class FrmDangKi : Form
    {
        string err;
        public FrmDangKi()
        {
            InitializeComponent();
        }
       
        private void ClearTextBox()
        {
            txtUser1.Clear();
            txtPass1.Clear();
            txtRepass1.Clear();
        }


        private void FrmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                BLLoGin blLg = new BLLoGin();
                if (txtPass1.Text == txtRepass1.Text)
                {
                    blLg.ThemUser(this.txtUser1.Text.Trim(), this.txtPass1.Text.Trim(), this.txtRepass1.Text.Trim(), Convert.ToBoolean(this.cbxPQuyen.Text), ref err);
                    MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mật khẩu phải giống nhau", "Lôi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("ko thêm đc. Lỗi r!.");
            }


            MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
        }
    }
}

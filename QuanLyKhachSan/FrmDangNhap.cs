using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.BS_Layer;
namespace QuanLyKhachSan
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities())
            {
                var user = qlksEntity.USER_INFO.FirstOrDefault(u => u.UserName == txtUser.Text.Trim());
                if (user != null)
                {
                    if (user.PassWord == txtPass.Text.Trim())
                    {
                        FrmMain.Islogin = (bool)user.UserType;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại tên tài khoản hoạc mật khẩu!");
                        txtUser.Focus();
                        txtUser.Clear();
                        txtPass.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại tên tài khoản hoạc mật khẩu!");
                    txtUser.Focus();
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Chắc không?", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
            {
                Close();
            }
        }
    }
}

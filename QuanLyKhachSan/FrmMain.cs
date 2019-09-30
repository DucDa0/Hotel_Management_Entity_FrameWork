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
    public partial class FrmMain : Form
    {
        public static bool Islogin = false;
        public FrmMain()
        {
            InitializeComponent();
            pbWelcome.Visible = false;
            menuQuanLy.Enabled = false;
            menuHoTroKH.Enabled = false;
            menuTools.Enabled = false;
            menuThoat.Enabled = true;
            menuDangKi.Enabled = false;
            menuThongKe.Enabled = false;
            menuDangNhap.Enabled = false;
            menuHeThong.Enabled = false;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }


        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDN = new FrmDangNhap();
            frmDN.ShowDialog();
            if (Islogin)
            {
                this.menuThongKe.Enabled = true;
                this.menuHeThong.Enabled = true;
                this.menuDangKi.Enabled = true;
                this.menuDangNhap.Enabled = true;
                this.menuTools.Enabled = true;
                this.menuHoTroKH.Enabled = true;
                this.menuQuanLy.Enabled = true;
                this.menuThoat.Enabled = true;
                this.menuQLKhachHang.Enabled = true;
                this.menuQLNhanVien.Enabled = true;
                this.menuQLChucVu.Enabled = true;
                this.menuQLHoaDon.Enabled = true;
                this.menuQLDichVu.Enabled = true;
                this.menuQLPhongThue.Enabled = true;
                this.menuQLLoaiPhong.Enabled = true;
                this.menuThongTinPhong.Enabled = true;
                this.menuDatPhong.Enabled = true;
                this.menuDatDV.Enabled = true;
                this.menuTraPhong.Enabled = true;
                this.menuTraCuuKH.Enabled = true;
                this.menuTraCuuHD.Enabled = true;
                this.menuTraCuuNV.Enabled = true;
            }
            else
            {
                this.menuThongKe.Enabled = true;
                this.menuHeThong.Enabled = true;
                this.menuDangKi.Enabled = false;
                this.menuDangNhap.Enabled = false;
                this.menuTools.Enabled = true;
                this.menuHoTroKH.Enabled = true;
                this.menuQuanLy.Enabled = true;
                this.menuThoat.Enabled = true;
                this.menuQLKhachHang.Enabled = true;
                this.menuQLNhanVien.Enabled = false;
                this.menuQLChucVu.Enabled = false;
                this.menuQLHoaDon.Enabled = true;
                this.menuQLDichVu.Enabled = false;
                this.menuQLPhongThue.Enabled = true;
                this.menuQLLoaiPhong.Enabled = false;
                this.menuThongTinPhong.Enabled = false;
                this.menuDatPhong.Enabled = true;
                this.menuDatDV.Enabled = true;
                this.menuTraPhong.Enabled = true;
                this.menuTraCuuKH.Enabled = true;
                this.menuTraCuuHD.Enabled = true;
                this.menuTraCuuNV.Enabled = true;
            }

        }

        public void KT()
        {
            if (Islogin)
            {
                this.menuThongKe.Enabled = true;
                this.menuHeThong.Enabled = true;
                this.menuDangKi.Enabled = true;
                this.menuDangNhap.Enabled = true;
                this.menuTools.Enabled = true;
                this.menuHoTroKH.Enabled = true;
                this.menuQuanLy.Enabled = true;
                this.menuThoat.Enabled = true;
                this.menuQLKhachHang.Enabled = true;
                this.menuQLNhanVien.Enabled = true;
                this.menuQLChucVu.Enabled = true;
                this.menuQLHoaDon.Enabled = true;
                this.menuQLDichVu.Enabled = true;
                this.menuQLPhongThue.Enabled = true;
                this.menuQLLoaiPhong.Enabled = true;
                this.menuThongTinPhong.Enabled = true;
                this.menuDatPhong.Enabled = true;
                this.menuDatDV.Enabled = true;
                this.menuTraPhong.Enabled = true;
                this.menuTraCuuKH.Enabled = true;
                this.menuTraCuuHD.Enabled = true;
                this.menuTraCuuNV.Enabled = true;
                this.menuThongKe.Enabled = true;
                this.menuTKDT.Enabled = true;
            }
            else
            {
                this.menuThongKe.Enabled = true;
                this.menuHeThong.Enabled = true;
                this.menuDangKi.Enabled = false;
                this.menuDangNhap.Enabled = false;
                this.menuTools.Enabled = true;
                this.menuHoTroKH.Enabled = true;
                this.menuQuanLy.Enabled = true;
                this.menuThoat.Enabled = true;
                this.menuQLKhachHang.Enabled = true;
                this.menuQLNhanVien.Enabled = false;
                this.menuQLChucVu.Enabled = false;
                this.menuQLHoaDon.Enabled = true;
                this.menuQLDichVu.Enabled = false;
                this.menuQLPhongThue.Enabled = true;
                this.menuQLLoaiPhong.Enabled = false;
                this.menuThongTinPhong.Enabled = false;
                this.menuDatPhong.Enabled = true;
                this.menuDatDV.Enabled = true;
                this.menuTraPhong.Enabled = true;
                this.menuTraCuuKH.Enabled = true;
                this.menuTraCuuHD.Enabled = true;
                this.menuTraCuuNV.Enabled = true;
            }
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
                        Islogin = (bool)user.UserType;
                        panel2.BackgroundImage = Properties.Resources.FrmMainGif;
                        txtPass.Visible = false;
                        txtUser.Visible = false;
                        btnDangNhap.Visible = false;
                        pbWelcome.Visible = true;
                        KT();
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
        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc Không?", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuQLKhachHang_Click(object sender, EventArgs e)
        {
            QLKhachHang frmQLKH = new QLKhachHang();
            frmQLKH.Show();
        }

        private void menuQLNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien frmQLNV = new QLNhanVien();
            frmQLNV.Show();
        }

        private void menuQLChucVu_Click(object sender, EventArgs e)
        {
            QLChucVu frmQLCV = new QLChucVu();
            frmQLCV.Show();
        }

        private void menuQLHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDonDV frmQLHD = new QLHoaDonDV();
            frmQLHD.Show();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDichVu frmQLDV = new QLDichVu();
            frmQLDV.Show();
        }

        private void menuQLPhongThue_Click(object sender, EventArgs e)
        {
            QLPhongThue frmQLPT = new QLPhongThue();
            frmQLPT.Show();
        }

        private void QLThongTinPhong_Click(object sender, EventArgs e)
        {
            QLPhongThue_Info frmQLTTP = new QLPhongThue_Info();
            frmQLTTP.Show();
        }

        private void menuDatPhong_Click(object sender, EventArgs e)
        {
            FrmDatPhong frmDP = new FrmDatPhong();
            frmDP.Show();
        }

        private void menuDatDV_Click(object sender, EventArgs e)
        {
            QLHoaDonDV frmQLHDDV = new QLHoaDonDV();
            frmQLHDDV.Show();
            FrmDatDichVu frmDV = new FrmDatDichVu();
            frmDV.Show();
        }

        private void menuTraCuuKH_Click(object sender, EventArgs e)
        {
            FrmTraCuuKhachHang frmTCKH = new FrmTraCuuKhachHang();
            frmTCKH.Show();
        }

        private void menuTraCuuHD_Click(object sender, EventArgs e)
        {
            FrmTraCuuHoaDonDV frmTCHD = new FrmTraCuuHoaDonDV();
            frmTCHD.Show();
        }

        private void menuQLLoaiPhong_Click(object sender, EventArgs e)
        {
            QLKieuPhong frmQLKP = new QLKieuPhong();
            frmQLKP.Show();
        }

        private void menuTraCuuNV_Click(object sender, EventArgs e)
        {
            FrmTraCuuNhanVien frmTCNV = new FrmTraCuuNhanVien();
            frmTCNV.Show();
        }

        private void menuDangKi_Click(object sender, EventArgs e)
        {
            FrmDangKi frmDK = new FrmDangKi();
            frmDK.ShowDialog();
        }

        private void menuTraPhong_Click(object sender, EventArgs e)
        {
            FrmTraPhong frmTP = new FrmTraPhong();
            frmTP.Show();
        }

        private void menuTKDT_Click(object sender, EventArgs e)
        {
            FrmThongKe frmTK = new FrmThongKe();
            frmTK.Show();
        }
    }
}

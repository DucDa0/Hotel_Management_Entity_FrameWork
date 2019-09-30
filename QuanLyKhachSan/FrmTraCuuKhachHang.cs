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
    public partial class FrmTraCuuKhachHang : Form
    {
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmTraCuuKhachHang()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rbCMND.Checked == true)
            {
                var list = (from s in qlksEntity.KHACHHANGs
                            join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                            join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                            join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                            where s.CMND.Contains(txtTimKiem.Text.Trim())
                            select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich, k.TenPhong, t.LoaiPhong, k.NgayDK, k.TinhTrang }).ToList();
                dgvHienThi.DataSource = list;
            }
            if (rbTenKH.Checked == true)
            {
                var list = (from s in qlksEntity.KHACHHANGs
                            join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                            join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                            join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                            where s.TenKH.Contains(txtTimKiem.Text.Trim())
                            select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich, k.TenPhong, t.LoaiPhong, k.NgayDK, k.TinhTrang }).ToList();
                dgvHienThi.DataSource = list;
            }
            if (rbMaKH.Checked == true)
            {
                var list = (from s in qlksEntity.KHACHHANGs
                            join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                            join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                            join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                            where s.MaKH.Contains(txtTimKiem.Text.Trim())
                            select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich, k.TenPhong, t.LoaiPhong, k.NgayDK, k.TinhTrang }).ToList();
                dgvHienThi.DataSource = list;
            }
            if (rbSDT.Checked == true)
            {
                var list = (from s in qlksEntity.KHACHHANGs
                            join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                            join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                            join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                            where s.SDT.Contains(txtTimKiem.Text.Trim())
                            select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich, k.TenPhong, t.LoaiPhong, k.NgayDK, k.TinhTrang }).ToList();
                dgvHienThi.DataSource = list;
            }
            if (cBOnl.Checked == true)
            {
                var list = (from s in qlksEntity.KHACHHANGs
                            join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                            join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                            join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                            where k.TinhTrang == "Onl"
                            select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich, k.TenPhong, t.LoaiPhong, k.NgayDK, k.TinhTrang }).ToList();
                dgvHienThi.DataSource = list;
            }
            if (cBOff.Checked == true)
            {
                var list = (from s in qlksEntity.KHACHHANGs
                            join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                            join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                            join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                            where k.TinhTrang == "Off"
                            select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich, k.TenPhong, t.LoaiPhong, k.NgayDK, k.TinhTrang }).ToList();
                dgvHienThi.DataSource = list;
            }
        }
    }
}

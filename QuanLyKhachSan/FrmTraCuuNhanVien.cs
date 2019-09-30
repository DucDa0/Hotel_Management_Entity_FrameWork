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
    public partial class FrmTraCuuNhanVien : Form
    {
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmTraCuuNhanVien()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rbMaNV.Checked == true)
            {
                var list = (from s in qlksEntity.NHANVIENs
                            join k in qlksEntity.CHUCVUs on s.MaChucVu equals k.MaChucVu
                            where s.MaNV == txtTimKiem.Text.Trim()
                            select new { s.MaNV, s.HoTen, s.NgaySinh, s.GioiTinh, s.CMND_NV, s.DiaChi, s.MaChucVu, k.ChucVu1 }).ToList();
                dgvNhanVien.DataSource = list;
            }
            if (rbCMND.Checked == true)
            {
                var list = (from s in qlksEntity.NHANVIENs
                            join k in qlksEntity.CHUCVUs on s.MaChucVu equals k.MaChucVu
                            where s.CMND_NV == txtTimKiem.Text.Trim()
                            select new { s.MaNV, s.HoTen, s.NgaySinh, s.GioiTinh, s.CMND_NV, s.DiaChi, s.MaChucVu, k.ChucVu1 }).ToList();
                dgvNhanVien.DataSource = list;
            }
            if (rbTenNV.Checked == true)
            {
                var list = (from s in qlksEntity.NHANVIENs
                            join k in qlksEntity.CHUCVUs on s.MaChucVu equals k.MaChucVu
                            where s.HoTen == txtTimKiem.Text.Trim()
                            select new { s.MaNV, s.HoTen, s.NgaySinh, s.GioiTinh, s.CMND_NV, s.DiaChi, s.MaChucVu, k.ChucVu1 }).ToList();
                dgvNhanVien.DataSource = list;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLNhanVien
    {
        public DataTable LayNhanVien()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.NHANVIENs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Mã Chức Vụ");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaNV, p.HoTen, p.NgaySinh, p.GioiTinh, p.CMND_NV, p.DiaChi, p.MaChucVu);
            }
            return dt;
        }
        public bool ThemNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string CMND_NV, string DiaChi, string MaChucVu, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            NHANVIEN nv = new NHANVIEN();
            nv.MaNV = MaNV;
            nv.HoTen = HoTen;
            nv.NgaySinh = NgaySinh;
            nv.GioiTinh = GioiTinh;
            nv.CMND_NV = CMND_NV;
            nv.DiaChi = DiaChi; ;
            nv.MaChucVu = MaChucVu;
            qlksEntity.NHANVIENs.Add(nv);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            NHANVIEN nv = new NHANVIEN();
            nv.MaNV = MaNV;
            qlksEntity.NHANVIENs.Attach(nv);
            qlksEntity.NHANVIENs.Remove(nv);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string CMND_NV, string DiaChi, string MaChucVu, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.NHANVIENs where dv.MaNV == MaNV select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.HoTen = HoTen;
                dvQuerry.NgaySinh = NgaySinh;
                dvQuerry.GioiTinh = GioiTinh;
                dvQuerry.CMND_NV = CMND_NV;
                dvQuerry.DiaChi = DiaChi;
                dvQuerry.MaChucVu = MaChucVu;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

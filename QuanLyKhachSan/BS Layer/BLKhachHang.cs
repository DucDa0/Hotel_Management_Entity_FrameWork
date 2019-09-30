using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLKhachHang
    {

        public DataTable LayKhachHang()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.KHACHHANGs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã KH");
            dt.Columns.Add("Tên KH");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("CMND");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Quốc Tịch");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaKH, p.TenKH, p.NgaySinh, p.GioiTinh, p.CMND, p.SDT, p.QuocTich);
            }
            return dt;
        }
        public bool ThemKhachHang(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string CMND, string SDT, string QuocTich, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            KHACHHANG kh = new KHACHHANG();
            kh.MaKH = MaKH;
            kh.TenKH = TenKH;
            kh.NgaySinh = NgaySinh;
            kh.GioiTinh = GioiTinh;
            kh.CMND = CMND;
            kh.SDT = SDT;
            kh.QuocTich = QuocTich;
            qlksEntity.KHACHHANGs.Add(kh);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            KHACHHANG kh = new KHACHHANG();
            kh.MaKH = MaKH;
            qlksEntity.KHACHHANGs.Attach(kh);
            qlksEntity.KHACHHANGs.Remove(kh);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string CMND, string SDT, string QuocTich, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.KHACHHANGs where dv.MaKH == MaKH select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.TenKH = TenKH;
                dvQuerry.NgaySinh = NgaySinh;
                dvQuerry.GioiTinh = GioiTinh;
                dvQuerry.CMND = CMND;
                dvQuerry.SDT = SDT;
                dvQuerry.QuocTich = QuocTich;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

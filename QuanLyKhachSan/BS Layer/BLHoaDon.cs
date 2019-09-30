using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLHoaDon
    {
        public DataTable LayHoaDon()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.HOADONs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã HĐ");
            dt.Columns.Add("Tên HĐ");
            dt.Columns.Add("Mã DV");
            dt.Columns.Add("Mã KH");
            dt.Columns.Add("Ngày Lập HĐ");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaHD, p.TenHD, p.MaDV, p.MaKH, p.NgayLapHD);
            }
            return dt;
        }
        public bool ThemHoaDon(string MaHD, string TenHD, string MaDV, string MaKH, DateTime NgayLapHD, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            HOADON hd = new HOADON();
            hd.MaHD = MaHD;
            hd.TenHD = TenHD;
            hd.MaDV = MaDV;
            hd.MaKH = MaKH;
            hd.NgayLapHD = NgayLapHD;
            qlksEntity.HOADONs.Add(hd);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaHoaDon(ref string err, string MaHD)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            HOADON hd = new HOADON();
            hd.MaHD = MaHD;
            qlksEntity.HOADONs.Attach(hd);
            qlksEntity.HOADONs.Remove(hd);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatHoaDon(string MaHD, string TenHD, string MaDV, string MaKH, DateTime NgayLapHD, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.HOADONs where dv.MaHD == MaHD select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.TenHD = TenHD;
                dvQuerry.MaDV = MaDV;
                dvQuerry.MaKH = MaKH;
                dvQuerry.NgayLapHD = NgayLapHD;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

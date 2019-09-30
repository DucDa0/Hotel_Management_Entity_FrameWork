using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLPhongThue
    {
        public DataTable LayPhongThue()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.PHONGTHUEs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã ĐK");
            dt.Columns.Add("Mã KH");
            dt.Columns.Add("Tên Phòng");
            dt.Columns.Add("Ngày Đkí");
            dt.Columns.Add("Tình Trạng");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaDK, p.MaKH, p.TenPhong, p.NgayDK, p.TinhTrang);
            }
            return dt;
        }
        public bool ThemPhongThue(string MaDK, string MaKH, string TenPhong, DateTime NgayDK, string TinhTrang, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            PHONGTHUE pt = new PHONGTHUE();
            pt.MaDK = MaDK;
            pt.MaKH = MaKH;
            pt.TenPhong = TenPhong;
            pt.NgayDK = NgayDK;
            pt.TinhTrang = TinhTrang;
            qlksEntity.PHONGTHUEs.Add(pt);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaPhongThue(ref string err, string MaDK)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            PHONGTHUE pt = new PHONGTHUE();
            pt.MaDK = MaDK;
            qlksEntity.PHONGTHUEs.Attach(pt);
            qlksEntity.PHONGTHUEs.Remove(pt);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatPhongThue(string MaDK, string MaKH, string TenPhong, DateTime NgayDK, string TinhTrang, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.PHONGTHUEs where dv.MaDK == MaDK select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.MaKH = MaKH;
                dvQuerry.TenPhong = TenPhong;
                dvQuerry.NgayDK = NgayDK;
                dvQuerry.TinhTrang = TinhTrang;
                qlksEntity.SaveChanges();
            }
            return true;
        }
        public bool CapNhatPhongThue1(string TenPhong, string TinhTrang, ref string err)
        {
            /*
            string sqlString = "Update PHONGTHUE Set TinhTrang=N'" +
             TinhTrang  + "'Where TenPhong='" + TenPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            */
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.PHONGTHUEs where dv.TenPhong == TenPhong select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.TinhTrang = TinhTrang;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

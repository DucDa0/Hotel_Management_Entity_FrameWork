using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLPhongThue_Info
    {
        public DataTable LayPhongThue_info()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.THONGTIN_PHONG select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Phòng");
            dt.Columns.Add("Loại Phòng");
            dt.Columns.Add("Tình Trạng");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.TenPhong, p.LoaiPhong, p.TinhTrang);
            }
            return dt;
        }
        public DataTable LayPhongThue_info1()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.THONGTIN_PHONG select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Phòng");
            dt.Columns.Add("Tình Trạng");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.TenPhong, p.TinhTrang);
            }
            return dt;
        }
        public bool ThemPhongThue_info(string TenPhong, string LoaiPhong, string TinhTrang, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            THONGTIN_PHONG ttp = new THONGTIN_PHONG();
            ttp.TenPhong = TenPhong;
            ttp.LoaiPhong = LoaiPhong;
            ttp.TinhTrang = TinhTrang;
            qlksEntity.THONGTIN_PHONG.Add(ttp);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaPhongThue_info(ref string err, string TenPhong)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            THONGTIN_PHONG ttp = new THONGTIN_PHONG();
            ttp.TenPhong = TenPhong;
            qlksEntity.THONGTIN_PHONG.Attach(ttp);
            qlksEntity.THONGTIN_PHONG.Remove(ttp);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatPhongThue_info(string TenPhong, string LoaiPhong, string TinhTrang, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.THONGTIN_PHONG where dv.TenPhong == TenPhong select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.LoaiPhong = LoaiPhong;
                dvQuerry.TinhTrang = TinhTrang;
                qlksEntity.SaveChanges();
            }
            return true;
        }
        public bool CapNhatPhongThue_info1(string TenPhong, string TinhTrang, ref string err)
        {
            /*
            string sqlString = "Update THONGTIN_PHONG Set TinhTrang=N'" +
               TinhTrang  + "'Where TenPhong='" + TenPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            */
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.THONGTIN_PHONG where dv.TenPhong == TenPhong select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.TinhTrang = TinhTrang;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

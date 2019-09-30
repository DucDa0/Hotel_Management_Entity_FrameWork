using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLLoaiPhong
    {
        public DataTable LayLoaiPhong()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.KIEUPHONGs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Loại Phòng");
            dt.Columns.Add("Giá Phòng");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.LoaiPhong, p.GiaPhong);
            }
            return dt;
        }
        public bool ThemLoaiPhong(string LoaiPhong, int GiaPhong, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            KIEUPHONG kp = new KIEUPHONG();
            kp.LoaiPhong = LoaiPhong;
            kp.GiaPhong = GiaPhong;
            qlksEntity.KIEUPHONGs.Add(kp);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaLoaiPhong(ref string err, string LoaiPhong)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            KIEUPHONG kp = new KIEUPHONG();
            kp.LoaiPhong = LoaiPhong;
            qlksEntity.KIEUPHONGs.Attach(kp);
            qlksEntity.KIEUPHONGs.Remove(kp);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatLoaiPhong(string LoaiPhong, int GiaPhong, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.KIEUPHONGs where dv.LoaiPhong == LoaiPhong select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.GiaPhong = GiaPhong;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

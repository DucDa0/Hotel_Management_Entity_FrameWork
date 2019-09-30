using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLDuLieu
    {
        public DataTable LayDuLieu()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.DULIEUx select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã KH");
            dt.Columns.Add("Tên KH");
            dt.Columns.Add("CMND");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("Tên Phòng");
            dt.Columns.Add("Quốc Tịch");
            dt.Columns.Add("Ngày Đkí");
            dt.Columns.Add("Ngày Đi");
            dt.Columns.Add("Tổng Tiền DV");
            dt.Columns.Add("Tổng Tiền Phòng");
            dt.Columns.Add("Tổng Tiền HĐ");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaKH, p.TenKH, p.CMND, p.SDT, p.GioiTinh, p.TenPhong, p.QuocTich, p.NgayDK, p.NgayDi, p.TongGiaDV, p.TongGiaPhong, p.TongGiaHD);
            }
            return dt;
        }
        public bool ThemDuLieu(string MaKH, string TenKH, string CMND, string SDT, string GioiTinh, string TenPhong, string QuocTich, DateTime NgayDK, DateTime NgayDi,
                int TongGiaDV, int TongGiaPhong, int TongGiaHD, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            DULIEU dl = new DULIEU();
            dl.MaKH = MaKH;
            dl.TenKH = TenKH;
            dl.CMND = CMND;
            dl.SDT = SDT;
            dl.GioiTinh = GioiTinh;
            dl.TenPhong = TenPhong;
            dl.QuocTich = QuocTich;
            dl.NgayDK = NgayDK;
            dl.NgayDi = NgayDi;
            dl.TongGiaDV = TongGiaDV;
            dl.TongGiaPhong = TongGiaPhong;
            dl.TongGiaHD = TongGiaHD;
            qlksEntity.DULIEUx.Add(dl);
            qlksEntity.SaveChanges();
            return true;
        }
        /*
        public bool XoaDuLieu(ref string err, string MaKH)
        {
            string sqlString = "Delete From  DULIEU Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDuLieu(string MaKH, string TenKH, string CMND, string SDT, string GioiTinh, string TenPhong, string QuocTich, DateTime NgayDK, DateTime NgayDi,
                 string TongGiaDV, string TongGiaPhong, string TongGiaHD, ref string err)
        {
            string sqlString = "Update  DULIEU Set TenKH=N'" +
            TenKH + "',CMND=N'" + CMND +"',SDT=N'"+SDT+ "',GioiTinh=N'" + GioiTinh + "',TenPhong=N'" + TenPhong + "',QuocTich=N'" +
            QuocTich +"',NgayDK=N'"+NgayDK+"',NgayDi=N'"+NgayDi+"',TongGiaDV=N'"+TongGiaDV+"',TongGiaPhong=N'"+TongGiaPhong+"',TongGiaHD=N'"+TongGiaHD+"'Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        */
    }
}

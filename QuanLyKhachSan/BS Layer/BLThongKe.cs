using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLThongKe
    {
        public DataTable LayTK()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.THONGKEs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thống Kê");
            dt.Columns.Add("Số Lượng KH");
            dt.Columns.Add("Số Lượng DV");
            dt.Columns.Add("Ngày Thống Kê");
            dt.Columns.Add("Tổng Doanh Thu");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaThongKe, p.SoLuongKH, p.SoLuongDV, p.NgayThongKe, p.TongDoanhThu);
            }
            return dt;
        }
        public bool ThemTK(int SoLuongKH, int SoLuongDV, DateTime NgayThongKe, int TongDoanhThu, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            THONGKE tk = new THONGKE();
            tk.SoLuongKH = SoLuongKH;
            tk.SoLuongDV = SoLuongDV;
            tk.NgayThongKe = NgayThongKe;
            tk.TongDoanhThu = TongDoanhThu;
            qlksEntity.THONGKEs.Add(tk);
            qlksEntity.SaveChanges();
            return true;
        }
        /*
        public bool XoaTK(ref string err, string MaThongKe)
        {
            string sqlString = "Delete From THONGKE Where MaThongKe='" + MaThongKe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTK(string MaThongKe, string SoLuongKH, string SoLuongDV, DateTime NgayThongKe, string TongDoanhThu, ref string err)
        {
            string sqlString = "Update THONGKE Set SoLuongKH=N'" +
               SoLuongKH + "',SoLuongDV=N'" + SoLuongDV + "',NgayThongKe=N'" + NgayThongKe + "',TongDoanhThu=N'" + TongDoanhThu + "'Where MaThongKe='" + MaThongKe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        */
    }
}

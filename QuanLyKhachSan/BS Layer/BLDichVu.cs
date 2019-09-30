using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLDichVu
    {
        public DataTable LayDichVu()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.DICHVUs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã DV");
            dt.Columns.Add("Tên DV");
            dt.Columns.Add("Giá DV");
            dt.Columns.Add("Mã NV");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaDV, p.TenDV, p.GiaDV, p.MaNV);
            }
            return dt;
        }
        public bool ThemDichVu(string MaDV, string TenDV, int GiaDV, string MaNV, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            DICHVU dv = new DICHVU();
            dv.MaDV = MaDV;
            dv.TenDV = TenDV;
            dv.GiaDV = GiaDV;
            dv.MaNV = MaNV;
            qlksEntity.DICHVUs.Add(dv);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool XoaDichVu(ref string err, string MaDV)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            DICHVU dv = new DICHVU();
            dv.MaDV = MaDV;
            qlksEntity.DICHVUs.Attach(dv);
            qlksEntity.DICHVUs.Remove(dv);
            qlksEntity.SaveChanges();
            return true;
        }
        public bool CapNhatDichVu(string MaDV, string TenDV, int GiaDV, string MaNV, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var dvQuerry = (from dv in qlksEntity.DICHVUs where dv.MaDV == MaDV select dv).SingleOrDefault();
            if (dvQuerry != null)
            {
                dvQuerry.TenDV = TenDV;
                dvQuerry.GiaDV = GiaDV;
                dvQuerry.MaNV = MaNV;
                qlksEntity.SaveChanges();
            }
            return true;
        }
    }
}

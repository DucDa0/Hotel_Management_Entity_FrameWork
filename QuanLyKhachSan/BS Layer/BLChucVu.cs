using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLChucVu
    {
        public DataTable LayChucVu()
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            var tps = from p in qlksEntity.CHUCVUs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Chức Vụ");
            dt.Columns.Add("Chức Vụ");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaChucVu, p.ChucVu1);
            }
            return dt;
        }
    }
}

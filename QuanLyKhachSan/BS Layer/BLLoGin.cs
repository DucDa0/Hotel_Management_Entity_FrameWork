using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhachSan.BS_Layer
{
    class BLLoGin
    {
        public bool ThemUser(string User, string pass,string repass ,bool phanquyen, ref string err)
        {
            QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
            USER_INFO ui = new USER_INFO();
            ui.UserName = User;
            ui.PassWord = pass;
            ui.RePassWord = repass;
            ui.UserType = phanquyen;
            qlksEntity.USER_INFO.Add(ui);
            qlksEntity.SaveChanges();
            return true;
        }
    }
}

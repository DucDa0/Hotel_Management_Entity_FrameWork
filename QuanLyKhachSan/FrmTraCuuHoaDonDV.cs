using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.BS_Layer;
namespace QuanLyKhachSan
{
    public partial class FrmTraCuuHoaDonDV : Form
    {
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmTraCuuHoaDonDV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rbMaHD.Checked == true)
            {
                var list = from s in qlksEntity.KHACHHANGs
                           join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                           join t in qlksEntity.HOADONs on s.MaKH equals t.MaKH
                           where t.MaHD == txtTimKiem.Text.Trim()
                           select new { s.MaKH, s.TenKH, s.CMND, s.SDT, s.GioiTinh, k.TenPhong };
                foreach (var p in list)
                {
                    txtMaKH.Text = (p.MaKH);
                    txtTenKH.Text = (p.TenKH);
                    txtCMND.Text = (p.CMND);
                    txtSDT.Text = (p.SDT);
                    txtGioiTinh.Text = (p.GioiTinh);
                    txtPhong.Text = (p.TenPhong);
                }
                var dv = (from s in qlksEntity.HOADONs
                          join k in qlksEntity.DICHVUs on s.MaDV equals k.MaDV
                          join t in qlksEntity.KHACHHANGs on s.MaKH equals t.MaKH
                          where s.MaHD == txtTimKiem.Text.Trim()
                          select new { s.MaHD, s.TenHD, s.MaDV, k.TenDV, k.GiaDV, s.NgayLapHD, k.MaNV }).ToList();
                listView1.Items.Clear();
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                int i = 0;
                foreach (var row in dv)
                {
                    listView1.Items.Add(row.MaHD);
                    listView1.Items[i].SubItems.Add(row.TenHD);
                    listView1.Items[i].SubItems.Add(row.MaDV);
                    listView1.Items[i].SubItems.Add(row.TenDV);
                    listView1.Items[i].SubItems.Add(row.GiaDV.ToString());
                    listView1.Items[i].SubItems.Add(((DateTime)row.NgayLapHD).ToShortDateString());
                    listView1.Items[i].SubItems.Add(row.MaNV);
                    i++;
                }
                int TongTienDV = 0;
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    TongTienDV += Convert.ToInt32(listView1.Items[j].SubItems[4].Text);
                }
                txtTongTienDV.Text = TongTienDV.ToString();
            }



            if (rbMaKH.Checked == true)
            {
                var list = from s in qlksEntity.KHACHHANGs
                           join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                           join t in qlksEntity.HOADONs on s.MaKH equals t.MaKH
                           where s.MaKH == txtTimKiem.Text.Trim()
                           select new { s.MaKH, s.TenKH, s.CMND, s.SDT, s.GioiTinh, k.TenPhong };
                foreach (var p in list)
                {
                    txtMaKH.Text = (p.MaKH);
                    txtTenKH.Text = (p.TenKH);
                    txtCMND.Text = (p.CMND);
                    txtSDT.Text = (p.SDT);
                    txtGioiTinh.Text = (p.GioiTinh);
                    txtPhong.Text = (p.TenPhong);
                }
                var dv = (from s in qlksEntity.HOADONs
                          join k in qlksEntity.DICHVUs on s.MaDV equals k.MaDV
                          join t in qlksEntity.KHACHHANGs on s.MaKH equals t.MaKH
                          where t.MaKH == txtTimKiem.Text.Trim()
                          select new { s.MaHD, s.TenHD, s.MaDV, k.TenDV, k.GiaDV, s.NgayLapHD, k.MaNV }).ToList();
                listView1.Items.Clear();
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                int i = 0;
                foreach (var row in dv)
                {
                    listView1.Items.Add(row.MaHD);
                    listView1.Items[i].SubItems.Add(row.TenHD);
                    listView1.Items[i].SubItems.Add(row.MaDV);
                    listView1.Items[i].SubItems.Add(row.TenDV);
                    listView1.Items[i].SubItems.Add(row.GiaDV.ToString());
                    listView1.Items[i].SubItems.Add(((DateTime)row.NgayLapHD).ToShortDateString());
                    listView1.Items[i].SubItems.Add(row.MaNV);
                    i++;
                }
                int TongTienDV = 0;
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    TongTienDV += Convert.ToInt32(listView1.Items[j].SubItems[4].Text);
                }
                txtTongTienDV.Text = TongTienDV.ToString();
            }



            if (rbCMND.Checked == true)
            {
                var list = from s in qlksEntity.KHACHHANGs
                           join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                           join t in qlksEntity.HOADONs on s.MaKH equals t.MaKH
                           where s.CMND == txtTimKiem.Text.Trim()
                           select new { s.MaKH, s.TenKH, s.CMND, s.SDT, s.GioiTinh, k.TenPhong };
                foreach (var p in list)
                {
                    txtMaKH.Text = (p.MaKH);
                    txtTenKH.Text = (p.TenKH);
                    txtCMND.Text = (p.CMND);
                    txtSDT.Text = (p.SDT);
                    txtGioiTinh.Text = (p.GioiTinh);
                    txtPhong.Text = (p.TenPhong);
                }
                var dv = (from s in qlksEntity.HOADONs
                          join k in qlksEntity.DICHVUs on s.MaDV equals k.MaDV
                          join t in qlksEntity.KHACHHANGs on s.MaKH equals t.MaKH
                          where t.CMND == txtTimKiem.Text.Trim()
                          select new { s.MaHD, s.TenHD, s.MaDV, k.TenDV, k.GiaDV, s.NgayLapHD, k.MaNV }).ToList();
                listView1.Items.Clear();
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                int i = 0;
                foreach (var row in dv)
                {
                    listView1.Items.Add(row.MaHD);
                    listView1.Items[i].SubItems.Add(row.TenHD);
                    listView1.Items[i].SubItems.Add(row.MaDV);
                    listView1.Items[i].SubItems.Add(row.TenDV);
                    listView1.Items[i].SubItems.Add(row.GiaDV.ToString());
                    listView1.Items[i].SubItems.Add(((DateTime)row.NgayLapHD).ToShortDateString());
                    listView1.Items[i].SubItems.Add(row.MaNV);
                    i++;
                }
                int TongTienDV = 0;
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    TongTienDV += Convert.ToInt32(listView1.Items[j].SubItems[4].Text);
                }
                txtTongTienDV.Text = TongTienDV.ToString();
            }

        }
    }
}

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
    public partial class FrmTraPhong : Form
    {
        string err;
        public static string MaKH;
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmTraPhong()
        {
            InitializeComponent();
            dtpNgayDi.Enabled = false;
            dtpNgayDK.Enabled = false;
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var list = (from s in qlksEntity.HOADONs
                        join k in qlksEntity.DICHVUs on s.MaDV equals k.MaDV
                        where s.MaKH == txtTimKiem.Text.Trim()
                        select new { s.MaHD, s.TenHD, s.MaDV, k.TenDV, k.GiaDV, k.MaNV }).ToList();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            int i = 0;
            foreach (var p in list)
            {
                listView1.Items.Add(p.MaHD);
                listView1.Items[i].SubItems.Add(p.TenHD);
                listView1.Items[i].SubItems.Add(p.MaDV);
                listView1.Items[i].SubItems.Add(p.TenDV);
                listView1.Items[i].SubItems.Add(p.GiaDV.ToString());
                listView1.Items[i].SubItems.Add(p.MaNV);
                i++;
            }
            int TongTienDV = 0;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                TongTienDV += Convert.ToInt32(listView1.Items[j].SubItems[4].Text);
            }
            var list1 = (from s in qlksEntity.KHACHHANGs
                         join k in qlksEntity.PHONGTHUEs on s.MaKH equals k.MaKH
                         join t in qlksEntity.THONGTIN_PHONG on k.TenPhong equals t.TenPhong
                         join b in qlksEntity.KIEUPHONGs on t.LoaiPhong equals b.LoaiPhong
                         where s.MaKH == txtTimKiem.Text.Trim()
                         select new { s.MaKH, s.TenKH, s.CMND, s.SDT, s.GioiTinh, s.QuocTich, k.TenPhong, k.NgayDK, b.GiaPhong }).ToList();
            int TienPhong = 0;
            foreach (var p in list1)
            {
                txtMaKH.Text = p.MaKH;
                txtTenKH.Text = p.TenKH;
                txtCMND.Text = p.CMND;
                txtSDT.Text = p.SDT;
                txtGioiTinh.Text = p.GioiTinh;
                txtPhong.Text = p.TenPhong;
                txtQuocTich.Text = p.QuocTich;
                dtpNgayDK.Text = p.NgayDK.ToString();
                TienPhong = Convert.ToInt32(p.GiaPhong);
            }
            MaKH = txtMaKH.Text;
            int TongTienPhong = 0;
            DateTime NgayDK = dtpNgayDK.Value;
            DateTime NgayDi = DateTime.Now;
            int NgayO = Math.Abs((NgayDi - NgayDK).Days);
            if (NgayO == 0)
            {
                txtTienDV.Text = TongTienDV.ToString();
                txtTienPhong.Text = TienPhong.ToString();
                txtTongTien.Text = (TongTienPhong + TongTienDV).ToString();
            }
            else
            {
                TongTienPhong = NgayO * TienPhong;
                txtTienPhong.Text = TongTienPhong.ToString();
                txtTongTien.Text = (TongTienPhong + TongTienDV).ToString();
                txtTienDV.Text = TongTienDV.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            string TinhTrang = "Off";
            BLPhongThue_Info blPt = new BLPhongThue_Info();
            blPt.CapNhatPhongThue_info1(this.txtPhong.Text.Trim(), TinhTrang, ref err);
            BLPhongThue blPt1 = new BLPhongThue();
            blPt1.CapNhatPhongThue1(this.txtPhong.Text.Trim(), TinhTrang, ref err);
            
            BLDuLieu blDL = new BLDuLieu();
            blDL.ThemDuLieu(this.txtMaKH.Text.Trim(), this.txtTenKH.Text.Trim(), this.txtCMND.Text.Trim(), this.txtSDT.Text.Trim(),
                this.txtGioiTinh.Text.Trim(), this.txtPhong.Text.Trim(), this.txtQuocTich.Text.Trim(),
                this.dtpNgayDK.Value, this.dtpNgayDi.Value, Convert.ToInt32(this.txtTienDV.Text.Trim()), Convert.ToInt32(this.txtTienPhong.Text.Trim()), Convert.ToInt32(this.txtTongTien.Text.Trim()), ref err);
            FrmHoaDonKH fk = new FrmHoaDonKH();
            fk.ShowDialog();
        }

        public string GetMaKH()
        {
            return MaKH;
        }
    }
}

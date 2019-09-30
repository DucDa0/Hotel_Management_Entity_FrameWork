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
    public partial class FrmHienTrangPhong : Form
    {
        BLPhongThue_Info dbPT_info = new BLPhongThue_Info();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmHienTrangPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvHienThi.DataSource = dbPT_info.LayPhongThue_info1();
        }

        private void FrmHienTrangPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHienThi.CurrentCell.RowIndex;
            this.txtTenPhong.Text =
            dgvHienThi.Rows[r].Cells[0].Value.ToString().Trim();
            this.cbxTinhTrang.Text =
            dgvHienThi.Rows[r].Cells[1].Value.ToString().Trim();
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            var list = (from s in qlksEntity.THONGTIN_PHONG
                        where s.TenPhong.Contains("A1") && s.TinhTrang == "Off"
                        select new { s.TenPhong, s.TinhTrang }).ToList();
            dgvHienThi.DataSource = list;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            var list = (from s in qlksEntity.THONGTIN_PHONG
                        where s.TenPhong.Contains("B1") && s.TinhTrang == "Off"
                        select new { s.TenPhong, s.TinhTrang }).ToList();
            dgvHienThi.DataSource = list;
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            var list = (from s in qlksEntity.THONGTIN_PHONG
                        where s.TenPhong.Contains("C1") && s.TinhTrang == "Off"
                        select new { s.TenPhong, s.TinhTrang }).ToList();
            dgvHienThi.DataSource = list;
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            var list = (from s in qlksEntity.THONGTIN_PHONG
                        where s.TenPhong.Contains("D1") && s.TinhTrang == "Off"
                        select new { s.TenPhong, s.TinhTrang }).ToList();
            dgvHienThi.DataSource = list;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        string err;
        private void btnSave_Click(object sender, EventArgs e)
        {
            BLPhongThue_Info blPt = new BLPhongThue_Info();
            blPt.CapNhatPhongThue_info1(this.txtTenPhong.Text.Trim(), this.cbxTinhTrang.Text.Trim(), ref err);
            LoadData();
            MessageBox.Show("Đã sửa xong");
        }
    }
}
